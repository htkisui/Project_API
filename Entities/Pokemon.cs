﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities;
public class Pokemon
{
    public int Id { get; set; }

    [Required]
    public string? Name { get; set; }
    public int Level { get; set; }

    public int TrainerId { get; set; }
    public virtual Trainer? Trainer { get; set;}
}