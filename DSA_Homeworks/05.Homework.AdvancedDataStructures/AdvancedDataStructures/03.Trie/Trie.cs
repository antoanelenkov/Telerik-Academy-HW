namespace AdvancedDataStructures
{
    using System.Collections.Generic;
    using System.Linq;

    internal class Trie
    {
        private class Node
        {
            public Node(char character)
            {
                this.Value = character;
                this.Count = 1;
                this.Children = new Dictionary<char, Node>();
            }

            public char Value { get; set; }

            public int Count { get; set; }

            public Dictionary<char, Node> Children { get; set; }

            public override int GetHashCode()
            {
                return this.Value.GetHashCode();
            }

            public override bool Equals(object obj)
            {
                var other = obj as Node;
                return this.Value.Equals(other.Value);
            }

            public override string ToString()
            {
                return string.Format("{0} -> {1} times", this.Value, this.Count);
            }
        }

        private readonly Node root;

        public Trie()
        {
            this.root = new Node('\0');
        }

        public void Add(string word)
        {
            var currentNode = this.root;

            int counter = 0;
            while (true)
            {
                if (counter >= word.Length)
                {
                    break;
                }

                if (currentNode.Children.Count == 0)
                {
                    foreach (var ch in word.Substring(counter))
                    {
                        currentNode.Children.Add(ch, new Node(ch));
                        currentNode = currentNode.Children[ch];
                    }

                    break;
                }

                if (currentNode.Children.ContainsKey(word[counter]))
                {
                    currentNode = currentNode.Children[word[counter]];
                    currentNode.Count++;
                }
                else
                {
                    currentNode.Children.Add(word[counter], new Node(word[counter]));
                    currentNode = currentNode.Children[word[counter]];
                }

                counter++;
            }
        }

        public int GetWordOccurance(string word)
        {
            var currentNode = this.root;

            var counter = 0;
            while (true)
            {
                if (counter == word.Length)
                {
                    if (currentNode.Children.Count == 0)
                    {
                        return currentNode.Count;
                    }
                    else
                    {
                        var childrenOcurences = 0;
                        foreach (var node in currentNode.Children)
                        {
                            childrenOcurences += node.Value.Count;
                        }

                        return currentNode.Count - childrenOcurences;
                    }
                }

                if (currentNode.Children.ContainsKey(word[counter]))
                {
                    currentNode = currentNode.Children[word[counter]];
                    counter++;
                }
                else
                {
                    break;
                }
            }

            return 0;
        }

        public int WordsCount
        {
            get
            {
                int answer = 0;

                foreach (var node in this.root.Children)
                {
                    answer += node.Value.Count;
                }

                return answer;
            }
        }

        public string GetMostCommonWord()
        {
            var node = this.root;

            string answer = null;
            char appendedLetter = '\0';

            while (node.Children.Count != 0)
            {
                var newNode = node.Children.First().Value;

                foreach (var child in node.Children)
                {
                    if (child.Value.Count >= newNode.Count)
                    {
                        newNode = child.Value;
                        appendedLetter = child.Key;
                    }
                }

                answer += appendedLetter;
                node = newNode;
            }

            return answer;
        }
    }
}
