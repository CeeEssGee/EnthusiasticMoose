using System;

Main();

void Main()
{
    // new line with \n
    Console.WriteLine("Welcome to the Enthusiastic Moose Simulator!\n--------------------------------------------\n");

    //Let the moose speak - twice
    MooseSays("HI, I'M ENTHUSIASTIC!");
    MooseSays("I really am enthusiastic");

    //Ask the moose a question
    // 4 separate functions replaced with QuestionWithParameters
    // CanadaQuestion();
    // EnthusiasticQuestion();
    // LoveCSharpQuestion();
    // SecretQuestion();
    QuestionWithParameters("Is Canada real?", "Really? It seems very unlikely.", "I  K N E W  I T !!!");
    QuestionWithParameters("Are you enthusiastic?", "Yay!", "You should try it!");
    QuestionWithParameters("Do you love C# yet?", "Good job sucking up to your instructor!", "You will...oh, yes, you will...");
    QuestionWithParameters("Do you want to know a secret?", "ME TOO!!!! I love secrets...tell me one!", "Oh, no...secrets are the best, I love to share them!");


}


void MooseSays(string message)
{
    Console.WriteLine($@"
                                       _.--^^^--,
                                    .'          `\
  .-^^^^^^-.                      .'              |
 /          '.                   /            .-._/
|             `.                |             |
 \              \          .-._ |          _   \
  `^^'-.         \_.-.     \   `          ( \__/
        |             )     '=.       .,   \
       /             (         \     /  \  /
     /`               `\        |   /    `'
     '..-`\        _.-. `\ _.__/   .=.
          |  _    / \  '.-`    `-.'  /
          \_/ |  |   './ _     _  \.'
               '-'    | /       \ |
                      |  .-. .-.  |
                      \ / o| |o \ /
                       |   / \   |    {message}
                      / `^`   `^` \
                     /             \
                    | '._.'         \
                    |  /             |
                     \ |             |
                      ||    _    _   /
                      /|\  (_\  /_) /
                      \ \'._  ` '_.'
                       `^^` `^^^`
    ");
};


// boolean = true or false
// MooseAsks = function name
// (string question) question is the parameter and is a string
bool MooseAsks(string question)
{
    // Moose asks a question with a y/n answer
    Console.Write($"{question} (Y/N): ");
    // system waits to for the user's the yes or no response
    string answer = Console.ReadLine().ToLower();

    // system accepts y or n responses if the answer is not y or n, the system repeats the question with a Y/N prompt
    while (answer != "y" && answer != "n")
    {
        Console.Write($"{question} (Y/N): ");
        answer = Console.ReadLine().ToLower();
    }

    // if answer is y, returns true
    if (answer == "y")
    {
        return true;
    }
    else // if not, answer is n and returns false
    {
        return false;
    }
};

// each parameter is going to be a string
void QuestionWithParameters(string questionAsked, string yesResponse, string noResponse)
{
    bool isTrue = MooseAsks(questionAsked);
    if (isTrue)
    {
        MooseSays(yesResponse);
    }
    else
    {
        MooseSays(noResponse);
    }

};

// Replaced with QuestionWithParameters
// void CanadaQuestion()
// {
//     bool isTrue = MooseAsks("Is Canada real?");
//     if (isTrue)
//     {
//         MooseSays("Really? It seems very unlikely.");
//     }
//     else
//     {
//         MooseSays("I  K N E W  I T !!!");
//     }
// }

// void EnthusiasticQuestion()
// {
//     bool isEnthusiastic = MooseAsks("Are you enthusiastic?");
//     if (isEnthusiastic)
//     {
//         MooseSays("Yay!");
//     }
//     else
//     {
//         MooseSays("You should try it!");
//     }
// }

// void LoveCSharpQuestion()
// {
//     bool doesLoveCSharp = MooseAsks("Do you love C# yet?");
//     if (doesLoveCSharp)
//     {
//         MooseSays("Good job sucking up to your instructor!");
//     }
//     else
//     {
//         MooseSays("You will...oh, yes, you will...");
//     }
// }

// void SecretQuestion()
// {
//     bool wantsSecret = MooseAsks("Do you want to know a secret?");
//     if (wantsSecret)
//     {
//         MooseSays("ME TOO!!!! I love secrets...tell me one!");
//     }
//     else
//     {
//         MooseSays("Oh, no...secrets are the best, I love to share them!");
//     }
// }