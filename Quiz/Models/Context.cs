using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Quiz.Models
{
    public class Context : DbContext
    {
        public Context()
            : base("name=DefaultConnection")
        {
        }

        public DbSet<Question> Questions { get; set; }
        public DbSet<Option> Options { get; set; }
        public DbSet<Answer> Answers { get; set; }


    }

    public class DatabaseInitializer : CreateDatabaseIfNotExists<Context>
    {
        protected override void Seed(Context context)
        {
            base.Seed(context);

            var questions = new List<Question>();

            questions.Add(new Question
            {
                Title = "1. Асуулт",
                Options = (new Option[]
                {
                    new Option { Title= "Хариулт 1", IsCorrect= false },
                    new Option { Title= "Хариулт 2", IsCorrect= false },
                    new Option { Title= "Хариулт 3", IsCorrect= true },
                    new Option { Title= "Хариулт 4", IsCorrect= false }
                }).ToList()
            });

            questions.Add(new Question
            {
                Title = "2. Асуулт",
                Options = (new Option[]
                {
                    new Option { Title= "Хариулт 1", IsCorrect= false },
                    new Option { Title= "Хариулт 2", IsCorrect= false },
                    new Option { Title= "Хариулт 3", IsCorrect= true },
                    new Option { Title= "Хариулт 4", IsCorrect= false }
                }).ToList()
            });


            questions.Add(new Question
            {
                Title = "3. Асуулт",
                Options = (new Option[]
                {
                    new Option { Title= "Хариулт 1", IsCorrect= false },
                    new Option { Title= "Хариулт 2", IsCorrect= false },
                    new Option { Title= "Хариулт 3", IsCorrect= true },
                    new Option { Title= "Хариулт 4", IsCorrect= false }
                }).ToList()
            });

            questions.Add(new Question
            {
                Title = "4. Асуулт",
                Options = (new Option[]
                {
                    new Option { Title= "Хариулт 1", IsCorrect= false },
                    new Option { Title= "Хариулт 2", IsCorrect= false },
                    new Option { Title= "Хариулт 3", IsCorrect= true },
                    new Option { Title= "Хариулт 4", IsCorrect= false }
                }).ToList()
            });

            questions.Add(new Question
            {
                Title = "5. Асуулт",
                Options = (new Option[]
                {
                    new Option { Title= "Хариулт 1", IsCorrect= false },
                    new Option { Title= "Хариулт 2", IsCorrect= false },
                    new Option { Title= "Хариулт 3", IsCorrect= true },
                    new Option { Title= "Хариулт 4", IsCorrect= false }
                }).ToList()
            });

            questions.Add(new Question
            {
                Title = "6. Асуулт",
                Options = (new Option[]
                {
                    new Option { Title= "Хариулт 1", IsCorrect= false },
                    new Option { Title= "Хариулт 2", IsCorrect= false },
                    new Option { Title= "Хариулт 3", IsCorrect= true },
                    new Option { Title= "Хариулт 4", IsCorrect= false }
                }).ToList()
            });

            questions.Add(new Question
            {
                Title = "7. Асуулт",
                Options = (new Option[]
                {
                    new Option { Title= "Хариулт 1", IsCorrect= false },
                    new Option { Title= "Хариулт 2", IsCorrect= false },
                    new Option { Title= "Хариулт 3", IsCorrect= true },
                    new Option { Title= "Хариулт 4", IsCorrect= false }
                }).ToList()
            });

            questions.Add(new Question
            {
                Title = "8. Асуулт",
                Options = (new Option[]
                {
                    new Option { Title= "Хариулт 1", IsCorrect= true },
                    new Option { Title= "Хариулт 2", IsCorrect= false },
                    new Option { Title= "Хариулт 3", IsCorrect= false },
                    new Option { Title= "Хариулт 4", IsCorrect= false }
                }).ToList()
            });

            questions.Add(new Question
            {
                Title = "9. Асуулт",
                Options = (new Option[]
                {
                    new Option { Title= "Хариулт 1", IsCorrect= false },
                    new Option { Title= "Хариулт 2", IsCorrect= false },
                    new Option { Title= "Хариулт 3", IsCorrect= true },
                    new Option { Title= "Хариулт 4", IsCorrect= false }
                }).ToList()
            });

            questions.Add(new Question
            {
                Title = "10. Асуулт",
                Options = (new Option[]
                {
                    new Option { Title= "Хариулт 1", IsCorrect= false },
                    new Option { Title= "Хариулт 2", IsCorrect= false },
                    new Option { Title= "Хариулт 3", IsCorrect= true },
                    new Option { Title= "Хариулт 4", IsCorrect= false }
                }).ToList()
            });

            questions.Add(new Question
            {
                Title = "11. Асуулт",
                Options = (new Option[]
                {
                    new Option { Title= "Хариулт 1", IsCorrect= false },
                    new Option { Title= "Хариулт 2", IsCorrect= false },
                    new Option { Title= "Хариулт 3", IsCorrect= true },
                    new Option { Title= "Хариулт 4", IsCorrect= false }
                }).ToList()
            });

            questions.Add(new Question
            {
                Title = "12. Асуулт",
                Options = (new Option[]
                {
                    new Option { Title= "Хариулт 1", IsCorrect= false },
                    new Option { Title= "Хариулт 2", IsCorrect= false },
                    new Option { Title= "Хариулт 3", IsCorrect= true },
                    new Option { Title= "Хариулт 4", IsCorrect= false }
                }).ToList()
            });

            questions.Add(new Question
            {
                Title = "13. Асуулт",
                Options = (new Option[]
                {
                    new Option { Title= "Хариулт 1", IsCorrect= false },
                    new Option { Title= "Хариулт 2", IsCorrect= false },
                    new Option { Title= "Хариулт 3", IsCorrect= true },
                    new Option { Title= "Хариулт 4", IsCorrect= false }
                }).ToList()
            });

            questions.Add(new Question
            {
                Title = "14. Асуулт",
                Options = (new Option[]
                {
                    new Option { Title= "Хариулт 1", IsCorrect= false },
                    new Option { Title= "Хариулт 2", IsCorrect= false },
                    new Option { Title= "Хариулт 3", IsCorrect= true },
                    new Option { Title= "Хариулт 4", IsCorrect= false }
                }).ToList()
            });

            questions.Add(new Question
            {
                Title = "15. Асуулт",
                Options = (new Option[]
                {
                    new Option { Title= "Хариулт 1", IsCorrect= false },
                    new Option { Title= "Хариулт 2", IsCorrect= false },
                    new Option { Title= "Хариулт 3", IsCorrect= true },
                    new Option { Title= "Хариулт 4", IsCorrect= false }
                }).ToList()
            });




            questions.ForEach(a => context.Questions.Add(a));

            context.SaveChanges();
        }
    }

}