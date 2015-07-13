function buttonOnClick(events, args) {
    var myWindow = window,
        browser = myWindow.navigator.appCodeName,
        browserIsMozilla = browser === "Mozilla" ? true : false;

    if (browserIsMozilla) {
        alert("Yes");
    } else {
        alert("No");
    }
}