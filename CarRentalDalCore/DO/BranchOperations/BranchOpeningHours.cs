﻿using DalApi.IEntity;

namespace DO;

// Represents the opening hours for a branch on a given day of the week.
public class BranchOpeningHours : IEntity
{
    /// <summary>
    /// Unique identifier for the opening hours entity.
    /// </summary>
    public int BranchOpeningHoursId { get; set; }

    /// <summary>
    /// The day of the week to which these opening hours apply.
    /// </summary>
    public DayOfWeek DayOfWeek { set; get; }

    /// <summary>
    /// The branch to which these opening hours apply.
    /// </summary>
    public Branch Branch { set; get; }

    /// <summary>
    /// Foreign key to the branch entity.
    /// </summary>
    public int BranchId { set; get; }

    /// <summary>
    /// The time at which the branch opens on the specified day of the week.
    /// </summary>
    public TimeOnly StartTime { set; get; }

    /// <summary>
    /// The time at which the branch closes on the specified day of the week.
    /// </summary>
    public TimeOnly EndTime { set; get; }
}

