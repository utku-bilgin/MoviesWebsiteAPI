using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Entities;

namespace DAL.Concrete.Context.EntityTypeConfiguration
{
    public class CategoryTypeConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {

            builder.HasData(
                new Category
                {
                    Id = Guid.Parse("2BA27383-5595-46BB-A4C7-0BF1393004A8"),
                    Name = "Aksiyon",
                    CreatedDate = DateTime.Now,
                    IsDeleted = false
                },
                new Category
                {
                    Id = Guid.Parse("517FDB38-4526-4136-B04E-F44DA166EB0D"),
                    Name = "Animasyon",
                    CreatedDate = DateTime.Now,
                    IsDeleted = false
                },
                new Category
                {
                    Id = Guid.Parse("9EE74F9E-E752-4876-92A6-7612FAA21125"),
                    Name = "Belgesel",
                    CreatedDate = DateTime.Now,
                    IsDeleted = false
                },
                new Category
                {
                    Id = Guid.Parse("073D0718-7198-495E-8BFC-282B3F312B87"),
                    Name = "Bilim Kurgu",
                    CreatedDate = DateTime.Now,
                    IsDeleted = false
                },
                new Category
                {
                    Id = Guid.Parse("62D09BE1-7149-4323-91B8-920F0E73B994"),
                    Name = "Biyografi",
                    CreatedDate = DateTime.Now,
                    IsDeleted = false
                },
                new Category
                {
                    Id = Guid.Parse("96F76275-6EAE-4F1D-A779-E2081708DBAF"),
                    Name = "Dram",
                    CreatedDate = DateTime.Now,
                    IsDeleted = false
                },
                new Category
                {
                    Id = Guid.Parse("0FE82780-5694-4810-8109-B2D81997B828"),
                    Name = "Fantastik",
                    CreatedDate = DateTime.Now,
                    IsDeleted = false
                },
                new Category
                {
                    Id = Guid.Parse("2FBE1558-2569-4A46-8C9A-2EE757FB1573"),
                    Name = "Gerilim",
                    CreatedDate = DateTime.Now,
                    IsDeleted = false
                },
                new Category
                {
                    Id = Guid.Parse("6F91D7CA-CC5A-47CD-9B19-58806496F045"),
                    Name = "Gizem",
                    CreatedDate = DateTime.Now,
                    IsDeleted = false
                },
                new Category
                {
                    Id = Guid.Parse("1370F594-9EF7-4CC5-95B7-2380B4C9B2D9"),
                    Name = "Komedi",
                    CreatedDate = DateTime.Now,
                    IsDeleted = false
                },
                new Category
                {
                    Id = Guid.Parse("12367738-4C57-4874-A1B6-EEBCCFE9ABA8"),
                    Name = "Korku",
                    CreatedDate = DateTime.Now,
                    IsDeleted = false
                },
                new Category
                {
                    Id = Guid.Parse("1B01FC9E-EF99-43AA-8557-D70897D141DD"),
                    Name = "Macera",
                    CreatedDate = DateTime.Now,
                    IsDeleted = false
                },
                new Category
                {
                    Id = Guid.Parse("12F37527-8D1B-4A9B-8EC9-77CBD37BB086"),
                    Name = "Müzik",
                    CreatedDate = DateTime.Now,
                    IsDeleted = false
                },
                new Category
                {
                    Id = Guid.Parse("6D0F565D-D05A-45D2-9475-F8D1F6AD1CD5"),
                    Name = "Polisiye",
                    CreatedDate = DateTime.Now,
                    IsDeleted = false
                },
                new Category
                {
                    Id = Guid.Parse("0F38E399-7019-4624-B05A-1A84A18E1D81"),
                    Name = "Reality",
                    CreatedDate = DateTime.Now,
                    IsDeleted = false
                },
                new Category
                {
                    Id = Guid.Parse("D2DBFCC0-A9F5-4008-8613-9F4F5086307D"),
                    Name = "Romantik",
                    CreatedDate = DateTime.Now,
                    IsDeleted = false
                },
                new Category
                {
                    Id = Guid.Parse("C7571C9A-A959-47D8-B3EA-DED35BB1CA91"),
                    Name = "Savaş",
                    CreatedDate = DateTime.Now,
                    IsDeleted = false
                },
                new Category
                {
                    Id = Guid.Parse("D5B3A8C5-F8DC-4495-B90F-D41EA9985878"),
                    Name = "Bilim Kurgu",
                    CreatedDate = DateTime.Now,
                    IsDeleted = false
                },
                new Category
                {
                    Id = Guid.Parse("541626C9-D0D2-491B-A8A8-ADDE6198B7CD"),
                    Name = "Kısa Film",
                    CreatedDate = DateTime.Now,
                    IsDeleted = false
                },
                new Category
                {
                    Id = Guid.Parse("D1EEC22C-A829-41BE-BE4B-5A2C15DBC4AB"),
                    Name = "Spor",
                    CreatedDate = DateTime.Now,
                    IsDeleted = false
                },
                new Category
                {
                    Id = Guid.Parse("4AB0190F-A4D4-49E8-8AC3-718481AA2A89"),
                    Name = "Suç",
                    CreatedDate = DateTime.Now,
                    IsDeleted = false
                },
                new Category
                {
                    Id = Guid.Parse("91F14291-3C71-44DA-8A4E-CA44F7A82C76"),
                    Name = "StandUp",
                    CreatedDate = DateTime.Now,
                    IsDeleted = false
                },
                new Category
                {
                    Id = Guid.Parse("ED6396FD-4FE3-4B75-B585-D10B933A4C51"),
                    Name = "Tarih",
                    CreatedDate = DateTime.Now,
                    IsDeleted = false
                },
                new Category
                {
                    Id = Guid.Parse("F88E8486-C147-44BC-8C98-A5BD9AE98D86"),
                    Name = "Western",
                    CreatedDate = DateTime.Now,
                    IsDeleted = false
                }
            );
        }
    }
}
