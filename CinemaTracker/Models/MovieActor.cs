using System.Collections.Generic;

namespace CinemaTracker.Models
{
    public class MovieActor
    {
        public int MovieActorId { get; set; }
        public int MovieId { get; set; }
        public int ActorId { get; set; }

        public Actor Actor { get; set; }

        public Movie Movie { get; set; }
    }
}