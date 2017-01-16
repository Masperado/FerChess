﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChessSharp.CoreStuff.Classes;

namespace ChessSharp.Models.ProfileViewModels
{
    public class ProfilePageModel
    {
        public ChessUser User { get; set; }
        public List<Request> Requests { get; set; }
        public List<ChessUser> Users { get; set; }
    }
}
