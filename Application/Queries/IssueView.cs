﻿using System;
using Persistence.Users;

namespace Persistence.Issues
{
    public class IssueView
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string UserName { get; set; }
    }
}