namespace _1._5_ClassesAndObjects;

public class Demo3
{
    public static void Run()
    {
        /*
         const model = {
            app: {
                loggedInUser: 'Dag'
                currentPage: 'main'
            },
            counter: 5,
            myTexts: [
                {
                    text: 'Dag',
                    col: 10,
                    row: 3
                },
                {
                    text: 'Dagmar',
                    col: 3,
                    row: 10
                }
            ]
        };
         */
        
        
        var model = new Model();
        model.Counter = 5;
        model.App = new App();
        model.App.LoggedInUser = "Dag";
        model.App.CurrentPage = "main";
        
        var customTexts = new CustomText[]
        {
            new CustomText
            {
                Text = "Dag",
                Column = 3,
                Row = 10
            },
            new CustomText
            {
                Text = "Dagmar",
                Column = 3,
                Row = 5
            }
        };
        
        model.MyTexts = customTexts;

        var sdfdf = ""; 

    }
}