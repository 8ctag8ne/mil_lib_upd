using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MilLib.Models.DTOs.Book;
using MilLib.Models.Entities;

namespace MilLib.Mappers
{
    public static class BookMapper
    {
        public static BookDto toBookDto(this Book book)
        {
            return new BookDto
            {
                Id = book.Id,
                AuthorId = book.AuthorId,
                Title = book.Title,
                ImageUrl = book.ImageUrl,
                FileUrl = book.FileUrl,
                Info = book.Info,
                Tags = book.Tags,
            };
        }

        public static Book toBookFromCreateDto(this BookCreateDto book)
        {
            return new Book
            {
                AuthorId = book.AuthorId,
                Title = book.Title,
                Info = book.Info,
            };
        }
    }
}