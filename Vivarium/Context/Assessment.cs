﻿using System;
using System.Collections.Generic;

namespace Vivarium.Context;

/// <summary>
/// Оценка пользователем книги
/// </summary>
public partial class Assessment
{
    public int Id { get; set; }

    public int? GradeId { get; set; }

    public int? UserId { get; set; }

    public int? BookId { get; set; }

    public virtual Book? Book { get; set; }

    public virtual Grade? Grade { get; set; }

    public virtual User? User { get; set; }
}
