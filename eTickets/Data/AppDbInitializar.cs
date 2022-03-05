using eTickets.Models;

namespace eTickets.Data
{
    public class AppDbInitializar
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                context.Database.EnsureCreated();

                //Cinemas
                if (!context.Cinemas.Any())
                {
                    context.Cinemas.AddRange(new List<Cinema>()
                    {
                        new Cinema()
                        {
                            Name = "金牌特務",
                            Logo = "http://www.truemovie.com/2016Poster/kingsman_the_golden_circle_ver23.jpg",
                            Description = "是一部於2017年上映的英國和美國合拍的動作間諜喜劇片"
                        },
                        new Cinema()
                        {
                            Name ="駭客任務4",
                            Logo = "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/thumbnail-%E9%A7%AD%E5%AE%A2%E4%BB%BB%E5%8B%99-%E5%BE%A9%E6%B4%BB-1639044549.jpeg?crop=0.894xw:0.625xh;0.0593xw,0.334xh&resize=640:*",
                            Description = "是一部於2021年上映的美國科幻動作片"
                        },
                        new Cinema()
                        {
                            Name ="惡靈古堡",
                            Logo = "https://eventcreate-v1.s3.us-west-1.amazonaws.com/uploads%2Ff4f705ba-03d7-44aa-96d5-1d9ae2175e85%2Fresident-evil-welcome-to-raccoon-city-french-poster-social-feature.jpg",
                            Description = "是一部於2017年上映的英國和美國合拍的動作間諜喜劇片"
                        },
                        new Cinema()
                        {
                            Name ="蜘蛛人無家日",
                            Logo = "https://assets.wmoov.com/movie/photo/202112/Spiderman_27x38poster_flying-imax_1639393574.jpg",
                            Description = "是一部2021年美國超級英雄電影，由漫威漫畫旗下角色蜘蛛人故事改編"
                        },
                        new Cinema()
                        {
                            Name ="蜘蛛人無家日",
                            Logo = "https://assets.wmoov.com/movie/photo/202112/Spiderman_27x38poster_flying-imax_1639393574.jpg",
                            Description = "是一部2021年美國超級英雄電影，由漫威漫畫旗下角色蜘蛛人故事改編"
                        },

                    });
                    context.SaveChanges();
                };
                //Actors
                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<Actor>()
                    {
                        new Actor()
                        {
                            FullName = "",
                            Bio = ""
                        },
                        new Actor()
                        {
                            Name ="駭客任務4",
                            Logo = "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/thumbnail-%E9%A7%AD%E5%AE%A2%E4%BB%BB%E5%8B%99-%E5%BE%A9%E6%B4%BB-1639044549.jpeg?crop=0.894xw:0.625xh;0.0593xw,0.334xh&resize=640:*",
                            Description = "是一部於2021年上映的美國科幻動作片"
                        },
                        new Actor()
                        {
                            Name ="惡靈古堡",
                            Logo = "https://eventcreate-v1.s3.us-west-1.amazonaws.com/uploads%2Ff4f705ba-03d7-44aa-96d5-1d9ae2175e85%2Fresident-evil-welcome-to-raccoon-city-french-poster-social-feature.jpg",
                            Description = "是一部於2017年上映的英國和美國合拍的動作間諜喜劇片"
                        },
                        new Actor()
                        {
                            Name ="蜘蛛人無家日",
                            Logo = "https://assets.wmoov.com/movie/photo/202112/Spiderman_27x38poster_flying-imax_1639393574.jpg",
                            Description = "是一部2021年美國超級英雄電影，由漫威漫畫旗下角色蜘蛛人故事改編"
                        },
                        new Actor()
                        {
                            Name ="蜘蛛人無家日",
                            Logo = "https://assets.wmoov.com/movie/photo/202112/Spiderman_27x38poster_flying-imax_1639393574.jpg",
                            Description = "是一部2021年美國超級英雄電影，由漫威漫畫旗下角色蜘蛛人故事改編"
                        },

                    });
                    context.SaveChanges();
                };
            }

        }
    }
}
