﻿namespace ProjectReview.Models.Entities
{
    public class Document
    {
        public long Id { get; set; }
        public DateTime CreateDate { get; set; }
        public long CreateUserId { get; set; }
        public int Number { get; set; } 
        public string Author { get; set; }
        public string Symbol { get; set; }
        public DateTime DateIssued { get; set; }
        public string Content { get; set; }
        public long DocumentTypeId { get; set; }
        public string Receiver { get; set; }
        public string FileName { get; set; }
        public int Density { get; set; }
        public int Urgency { get; set; }
        public int NumberPaper { get; set; }
        public string Language { get; set; }
        public string Signer { get; set; }
        public string Position { get; set; }
        public string Note { get; set; }
        public Boolean IsAssign { get; set; }
        public int Type { get; set; }

        public virtual User CreateUser { get; set; }
        public virtual DocumentType DocumentType { get; set; }
    }
}
