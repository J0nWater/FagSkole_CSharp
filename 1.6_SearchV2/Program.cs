
using _1._6_SearchV2;

var search = new SearchQuery();
search.Text = "kebab";
search.Dates = new Dates
{
    IncludeFromAndTo = true,
    From = DateTime.Parse("2025.05.10"),
    To = new DateTime(2025, 5, 10)
};

Console.WriteLine(search.Dates.From);

// var search = new SearchQuery("kebab", 
//     new Dates
//     {
//         IncludeFromAndTo = true,
//         From = new DateTime(2025, 5, 10),
//         To = new DateTime(2025, 5, 10)
//     });

/*
    let search = {
        text: 'kebab',
        dates: {
            includeFromAndTo : true,
            from: {
                day: 10,
                month: 5,
                year: 2023
            },
            to: {
                day: 10,
                month: 5,
                year: 2023
            }
        }
    }
 */
