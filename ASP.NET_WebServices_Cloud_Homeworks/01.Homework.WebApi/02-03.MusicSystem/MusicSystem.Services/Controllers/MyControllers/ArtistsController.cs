using AutoMapper;
using MusicSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using WebApplication1.Models.MyModels;

namespace WebApplication1.Controllers.MyControllers
{
    public class ArtistsController : BaseController
    {
        public ArtistsController()
        {
            Mapper.CreateMap<ArtistModel, Artist>();
            Mapper.CreateMap<SongModel, Song>();
            //Mapper does not map the collection of songs. Why?!?
            Mapper.CreateMap<Artist, ArtistModel>()
                .ForMember(x => x.Songs, o => o.MapFrom(src => Mapper.Map<ICollection<Song>,ICollection<SongModel>>(src.Songs)));
        }

        [HttpGet]
        public IHttpActionResult All()
        {
            var artists = this.Db.Artists.All();
            var artistsToShow = new List<ArtistModel>();

            foreach (var artist in artists)
            {
                artistsToShow.Add(Mapper.Map<Artist, ArtistModel>(artist));
            }

            return Ok(artistsToShow);
        }

        [HttpPost]
        public IHttpActionResult Add(ArtistModel artist)
        {
            if (!this.ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Artist artistToAdd = Mapper.Map<ArtistModel, Artist>(artist);

            this.Db.Artists.Add(artistToAdd);
            this.Db.SaveChanges();
            artist.Id = artistToAdd.Id;

            return Ok(artistToAdd);
        }

        [HttpPost]
        public IHttpActionResult AddSong(int id, SongModel song)
        {
            var artistToUpdate = this.Db.Artists.Find(id);

            if (artistToUpdate == null)
            {
                return BadRequest("Artist not found!");
            }
            else if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var songToAdd = Mapper.Map<SongModel, Song>(song);
            artistToUpdate.Songs.Add(songToAdd);
            this.Db.SaveChanges();

            return Ok("Song has been added");
        }

        [HttpPut]
        public IHttpActionResult Update(int id, ArtistModel artist)
        {
            var artistToUpdate = this.Db.Artists.Find(id);

            if (artistToUpdate == null)
            {
                return BadRequest("Artist not found!");
            }
            else if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Mapper.Map<ArtistModel, Artist>(artist);

            this.Db.SaveChanges();

            artist = Mapper.Map<Artist, ArtistModel>(artistToUpdate);

            return Ok(artist);
        }

        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            var artistToDelete = this.Db.Artists.Find(id);

            if (artistToDelete == null)
            {
                return BadRequest("Artist not found!");
            }

            this.Db.Artists.Delete(artistToDelete);
            this.Db.SaveChanges();

            return Ok("artist has been deleted");
        }
    }
}