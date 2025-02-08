<<<<<<< Updated upstream
<<<<<<< Updated upstream
using System;
using System.Collections.Generic;
using System.Threading.Tasks.Dataflow;

namespace Journal4
{

    public class Prompt
    {
        // setup variables
        Journal quote = new Journal();

        public void DisplayQuotes()
        {
            string[] quotes = {"What is holding you back from achieving your goals or living your dream life?",
"What are your favorite memories from childhood? Why do they stand out to you?",
"What did you wish was different about your childhood?",
"How has that impacted who you are today?",
"What 5 lessons would you tell your 18-year-old self?",
"What goals did you have 5 years ago? Do you still want the same things?",
"Who were the most present adults in your life when you were growing up? What did you learn from them?",
"Would your younger self be proud of you?",
"What are the biggest challenges you have overcome in your life? How did you do it?",
"What are your biggest strengths? How can you use them to achieve your goals?",
"What are your biggest weaknesses? How can you work to overcome them?",
"What are your biggest accomplishments? How did you achieve them?",
"What are your biggest regrets? How can you learn from them?",
"What is your biggest source of stress? How can you manage it?",
"How do you typically deal with negative emotions? Do you have a healthy outlet or is it more of a coping mechanism?",
"What is your biggest source of joy? How can you cultivate more of it?",
"Do you keep a gratitude journal? What are you most grateful for in your life?",
"What are the biggest challenges you are facing right now? How can you work to overcome them?",
"What are the most important things you have learned in life so far?"};


            // -- creating random number
            Random randomGenerator = new Random();
            int rn = randomGenerator.Next(0, 19);

            // add quote to journal
            Console.WriteLine(quotes[rn]);                                  
            quote._entry = quotes[rn];            

        }
    }
}
=======
=======
>>>>>>> Stashed changes
using System;
using System.Collections.Generic;
using System.Threading.Tasks.Dataflow;

namespace Journal4
{

    public class Prompt
    {
        // setup variables
        Journal quote = new Journal();

        public void DisplayQuotes()
        {
            string[] quotes = {"What is holding you back from achieving your goals or living your dream life?",
"What are your favorite memories from childhood? Why do they stand out to you?",
"What did you wish was different about your childhood?",
"How has that impacted who you are today?",
"What 5 lessons would you tell your 18-year-old self?",
"What goals did you have 5 years ago? Do you still want the same things?",
"Who were the most present adults in your life when you were growing up? What did you learn from them?",
"Would your younger self be proud of you?",
"What are the biggest challenges you have overcome in your life? How did you do it?",
"What are your biggest strengths? How can you use them to achieve your goals?",
"What are your biggest weaknesses? How can you work to overcome them?",
"What are your biggest accomplishments? How did you achieve them?",
"What are your biggest regrets? How can you learn from them?",
"What is your biggest source of stress? How can you manage it?",
"How do you typically deal with negative emotions? Do you have a healthy outlet or is it more of a coping mechanism?",
"What is your biggest source of joy? How can you cultivate more of it?",
"Do you keep a gratitude journal? What are you most grateful for in your life?",
"What are the biggest challenges you are facing right now? How can you work to overcome them?",
"What are the most important things you have learned in life so far?"};


            // -- creating random number
            Random randomGenerator = new Random();
            int rn = randomGenerator.Next(0, 19);

            // add quote to journal
            Console.WriteLine(quotes[rn]);                                  
            quote._entry = quotes[rn];            

        }
    }
}
<<<<<<< Updated upstream
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
