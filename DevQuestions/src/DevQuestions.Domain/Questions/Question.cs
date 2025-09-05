﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevQuestions.Domain.Questions
{
    public class Question
    {
        public Guid Id { get; set; }

        public required string Title { get; set; }
        public required string Text { get; set; }
        public Guid ScreenshotId { get; set; }
        public required Guid UserId { get; set; }
        public List<Answer> Answers { get; set; } = [];
        public Answer? Solution { get; set; }
        public List<Guid> Comments { get; set; } = [];
    }
}
