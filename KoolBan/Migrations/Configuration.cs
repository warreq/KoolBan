using KoolBan.Models;
using KoolBan.Models.Security;

namespace KoolBan.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<KoolBanContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(KoolBanContext context)
        {

            context.Projects.AddOrUpdate(
                p => p.ProjectId,
                new Project { ProjectId = "Demo", IsPrivate = false }
            );

            context.Columns.AddOrUpdate(
                c => c.ColumnId,
                new Column { ColumnId = 1, ColumnName = "To Do", Priority = 1, ProjectId = "Demo" },
                new Column { ColumnId = 2, ColumnName = "In Progress", Priority = 2, Capacity = 4, ProjectId = "Demo" },
                new Column { ColumnId = 3, ColumnName = "Test", Priority = 3, Capacity = 4, ProjectId = "Demo" },
                new Column { ColumnId = 4, ColumnName = "Done", Priority = 4, ProjectId = "Demo" }
            );

            context.Notes.AddOrUpdate(
                 n => n.NoteId,
                 new Note { NoteId = 1, ColumnId = 1, Description = "Eat a piece of cake", Logo = "heart", Color = "Green" },
                 new Note { NoteId = 2, ColumnId = 2, Description = "Cut the cake into pieces", Logo = "heart", Color = "Green" },
                 new Note { NoteId = 3, ColumnId = 3, Description = "Check if the cake is poisonous", Logo = "heart", Color = "Green" },
                 new Note { NoteId = 4, ColumnId = 4, Description = "Check if the cake is a lie. Note: It wasn't a lie!", Logo = "heart", Color = "Green" },
                 new Note { NoteId = 5, ColumnId = 4, Description = "Purchase cake using Siri", Logo = "heart", Color = "Green" },
                 new Note { NoteId = 6, ColumnId = 4, Description = "Teach a mouse to ride a bike", Logo = "plane", Color = "Orange" },
                 new Note { NoteId = 7, ColumnId = 2, Description = "Purchase a space rocket big enough to carry at least 40 mice to Mars", Logo = "plane", Color = "Orange" },
                 new Note { NoteId = 8, ColumnId = 1, Description = "Come up with a cool name for the mice. Note: Something with Biker...", Logo = "plane", Color = "Orange" },
                 new Note { NoteId = 9, ColumnId = 3, Description = "Figure out how to get enough cash for the trip using crowdfunding", Logo = "plane", Color = "Orange" },
                 new Note { NoteId = 10, ColumnId = 2, Description = "Research how to make all clouds in the world rainbow-coloured", Logo = "eye-open", Color = "Teal" },
                 new Note { NoteId = 11, ColumnId = 3, Description = "Research how to make all water in the world rainbow-coloured", Logo = "eye-open", Color = "Teal" },
                 new Note { NoteId = 12, ColumnId = 4, Description = "Research how to make all food in the world rainbow-coloured", Logo = "eye-open", Color = "Teal" },
                 new Note { NoteId = 13, ColumnId = 1, Description = "Research how to undo all rainbow-colour changes made", Logo = "eye-open", Color = "Teal" },
                 new Note { NoteId = 14, ColumnId = 1, Description = "Buy flowers for a loved one", Logo = "usd", Color = "Pink" },
                 new Note { NoteId = 15, ColumnId = 3, Description = "Buy a unicorn for your best friend", Logo = "usd", Color = "Red" },
                 new Note { NoteId = 16, ColumnId = 4, Description = "Purchase a jet-pack", Logo = "usd", Color = "Emerald" },
                 new Note { NoteId = 17, ColumnId = 2, Description = "Organise work desk", Logo = "tasks", Color = "Crimson" },
                 new Note { NoteId = 18, ColumnId = 3, Description = "Clean all windows", Logo = "tasks", Color = "Indigo" },
                 new Note { NoteId = 19, ColumnId = 4, Description = "Learn how to juggle", Logo = "tasks", Color = "Violet" }
             );

            context.Projects.AddOrUpdate(
              p => p.ProjectId,
              new Project { ProjectId = "Unicorn", IsPrivate = false }
          );

            context.Columns.AddOrUpdate(
                c => c.ColumnId,
                new Column { ColumnId = 5, ColumnName = "To Do", Priority = 1, ProjectId = "Unicorn" },
                new Column { ColumnId = 6, ColumnName = "In Progress", Priority = 2, Capacity = 4, ProjectId = "Unicorn" },
                new Column { ColumnId = 7, ColumnName = "Test", Priority = 3, Capacity = 4, ProjectId = "Unicorn" },
                new Column { ColumnId = 8, ColumnName = "Done", Priority = 4, ProjectId = "Unicorn" }
            );

            context.Notes.AddOrUpdate(
                n => n.NoteId,
                new Note { NoteId = 20, ColumnId = 5, Description = "Eat a piece of unicorn", Logo = "heart", Color = "Green" },
                new Note { NoteId = 21, ColumnId = 6, Description = "Cut the unicorn into pieces", Logo = "heart", Color = "Green" },
                new Note { NoteId = 22, ColumnId = 7, Description = "Check if the unicorn is poisonous", Logo = "heart", Color = "Green" },
                new Note { NoteId = 23, ColumnId = 8, Description = "Check if the unicorn is a lie. Note: It wasn't a lie!", Logo = "heart", Color = "Green" },
                new Note { NoteId = 24, ColumnId = 8, Description = "Purchase unicorn using Siri", Logo = "heart", Color = "Green" },
                new Note { NoteId = 25, ColumnId = 8, Description = "Teach a mouse to ride a bike", Logo = "plane", Color = "Orange" },
                new Note { NoteId = 26, ColumnId = 6, Description = "Purchase a space rocket big enough to carry at least 40 mice to Mars", Logo = "plane", Color = "Orange" },
                new Note { NoteId = 27, ColumnId = 5, Description = "Come up with a cool name for the mice. Note: Something with Biker...", Logo = "plane", Color = "Orange" },
                new Note { NoteId = 28, ColumnId = 7, Description = "Figure out how to get enough cash for the trip using crowdfunding", Logo = "plane", Color = "Orange" },
                new Note { NoteId = 29, ColumnId = 6, Description = "Research how to make all clouds in the world rainbow-coloured", Logo = "eye-open", Color = "Teal" },
                new Note { NoteId = 30, ColumnId = 7, Description = "Research how to make all water in the world rainbow-coloured", Logo = "eye-open", Color = "Teal" },
                new Note { NoteId = 31, ColumnId = 8, Description = "Research how to make all food in the world rainbow-coloured", Logo = "eye-open", Color = "Teal" },
                new Note { NoteId = 32, ColumnId = 5, Description = "Research how to undo all rainbow-colour changes made", Logo = "eye-open", Color = "Teal" },
                new Note { NoteId = 33, ColumnId = 5, Description = "Buy flowers for a loved one", Logo = "usd", Color = "Pink" },
                new Note { NoteId = 34, ColumnId = 7, Description = "Buy a unicorn for your best friend", Logo = "usd", Color = "Red" },
                new Note { NoteId = 35, ColumnId = 8, Description = "Purchase a jet-pack", Logo = "usd", Color = "Emerald" },
                new Note { NoteId = 36, ColumnId = 6, Description = "Organise work desk", Logo = "tasks", Color = "Crimson" },
                new Note { NoteId = 37, ColumnId = 7, Description = "Clean all windows", Logo = "tasks", Color = "Indigo" },
                new Note { NoteId = 38, ColumnId = 8, Description = "Learn how to juggle", Logo = "tasks", Color = "Violet" }
            );


            context.Projects.AddOrUpdate(
                p => p.ProjectId,
                new Project { ProjectId = "Secret", IsPrivate = true, Password = PasswordHash.CreateHash("password") }
            );

            context.Columns.AddOrUpdate(
            c => c.ColumnId,
            new Column { ColumnId = 9, ColumnName = "To Do", Priority = 1, ProjectId = "Secret" },
            new Column { ColumnId = 10, ColumnName = "In Progress", Priority = 2, Capacity = 4, ProjectId = "Secret" },
            new Column { ColumnId = 11, ColumnName = "Test", Priority = 3, Capacity = 4, ProjectId = "Secret" },
            new Column { ColumnId = 12, ColumnName = "Done", Priority = 4, ProjectId = "Secret" }
            );

            context.Notes.AddOrUpdate(
            n => n.NoteId,
            new Note { NoteId = 39, ColumnId = 9, Description = "Eat a piece of cake", Logo = "heart", Color = "Green" },
            new Note { NoteId = 40, ColumnId = 10, Description = "Cut the cake into pieces", Logo = "heart", Color = "Green" },
            new Note { NoteId = 41, ColumnId = 11, Description = "Check if the cake is poisonous", Logo = "heart", Color = "Green" },
            new Note { NoteId = 42, ColumnId = 12, Description = "Check if the cake is a lie. Note: It wasn't a lie!", Logo = "heart", Color = "Green" },
            new Note { NoteId = 43, ColumnId = 12, Description = "Purchase cake using Siri", Logo = "heart", Color = "Green" },
            new Note { NoteId = 44, ColumnId = 12, Description = "Teach a mouse to ride a bike", Logo = "plane", Color = "Orange" },
            new Note { NoteId = 45, ColumnId = 10, Description = "Purchase a space rocket big enough to carry at least 40 mice to Mars", Logo = "plane", Color = "Orange" },
            new Note { NoteId = 46, ColumnId = 9, Description = "Come up with a cool name for the mice. Note: Something with Biker...", Logo = "plane", Color = "Orange" }
            );
        }

    }
}
