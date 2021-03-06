﻿// -----------------------------------------------------------------------
// <copyright file="IInto.cs" company="MicroLite">
// Copyright 2012 - 2013 Project Contributors
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//    http://www.apache.org/licenses/LICENSE-2.0
//
// </copyright>
// -----------------------------------------------------------------------
namespace MicroLite.Query
{
    using System;

    /// <summary>
    /// The into method in the fluent insert sql builder syntax.
    /// </summary>
    public interface IInto
    {
        /// <summary>
        /// The table to perform the query against.
        /// </summary>
        /// <param name="tableName">The name of the table.</param>
        /// <returns>The next step in the fluent sql builder.</returns>
        IInsertValue Into(string tableName);

        /// <summary>
        /// The type to perform the query against.
        /// </summary>
        /// <param name="forType">The type of object the query relates to.</param>
        /// <returns>The next step in the fluent sql builder.</returns>
        IInsertValue Into(Type forType);
    }
}