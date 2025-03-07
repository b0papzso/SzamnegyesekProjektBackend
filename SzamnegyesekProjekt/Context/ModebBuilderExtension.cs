using Microsoft.EntityFrameworkCore;
using SzamnegyesekProjekt.Models;

namespace SzamnegyesekProjekt.Context
{
    public static class ModebBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Szamnegyesek>().HasData(
                new Szamnegyesek
                {
                    Id = new Guid(),
                    Szamok = new int[] { 1, 2, 3, 4 }
                },
                new Szamnegyesek
                {
                    Id = new Guid(),
                    Szamok = new int[] { 5, 6, 7, 8 }
                },
                new Szamnegyesek
                {
                    Id = new Guid(),
                    Szamok = new int[] { 9, 10, 11, 12 }
                }
            );
        }
    }
}
