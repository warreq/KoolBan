﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Web;

namespace KoolBan.Models
{
    public class Note
    {
        public int NoteId { get; set; }
        [Required]
        public String Description { get; set; }
        [Required]
        public int ColumnId { get; set; } // Foreign key
        public Column Column { get; set; }
        public String Logo { get; set; }

        [Display(Name = "Color")]
        public NoteColor NoteColor { get; set; }
    }

    public enum NoteColor
    {
        Black,
        Lime,
        Green,
        Emerald,
        Teal,
        Cyan,
        Cobalt,
        Indigo,
        Violet,
        Pink,
        Magenta,
        Crimson,
        Red,
        Orange,
        Amber,
        Yellow,
        Brown,
        Olive,
        Steel,
        Mauve,
        Taupe,
        Gray
    }

}