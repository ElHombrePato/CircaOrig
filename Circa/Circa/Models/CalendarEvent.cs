﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Circa.Models
{
    public class CalendarEvent
    {
        // public static readonly Color Black = new Color(0, 0, 0);

        //private int id = 0;
        private string title = "<Sin título>";
        private string description = "<Sin descripción>";
        private string type = "<Sin tipo>";
        //collection notas
        private User admin;
        private DateTimeOffset voteLimit = DateTimeOffset.UtcNow;

        public CalendarEvent() { }

        public CalendarEvent(string title, string description, string type, User admin, DateTimeOffset voteLimit)
        {
            Title = title;
            Description = description;
            Type = type;
            Admin = admin;
            VoteLimit = voteLimit;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append(Title);
            sb.Append(" - ");
            sb.Append(Admin.Nickname);
            sb.Append(" - ");
            sb.Append(voteLimit);

            return sb.ToString();
        }

        public string VoteLimitDate() => VoteLimit.DateTime.Day.ToString();

        public string VoteLimitTime() => VoteLimit.DateTime.Day.ToString();

        public string Title { get => title; set => title = value; }
        public string Description { get => description; set => description = value; }
        public string Type { get => type; set => type = value; }
        internal User Admin { get => admin; set => admin = value; }
        public DateTimeOffset VoteLimit { get => voteLimit; set => voteLimit = value; }



        /*
                public int Id
                {
                    get => Id;
                    private set
                    {
                        if(Id == 0)
                        {
                            Random rnd = new Random();
                            Id = rnd.Next(1, 10000);
                        }

                    }
                }

                public string Title {
                    get => Title;
                    set
                    {
                        if((value.Length>0) && (value.Length < 30))
                        {
                            Title = value;
                        }

                    }
                }
        */
    }
}
