namespace Bot_common
{
    public class Repliques
    {
        public Dictionary<int, string> GetEntries(Bot bot, string globalUsername)
        {
            Dictionary<int, string> replies = new ();
            switch (bot.Id)
            {
                case BotIdentifier.MonsieurGarrissonID:
                    replies = new Dictionary<int, string>
                    {
                        {1, "Oh oh alerte aux gogoles ! Alerte aux gogoles les enfants ! Toi aussi tu aimes les spaghettis volants monstrueux, pauvre imbécile ?"},
                        {2, string.Format("{0},  je rêve ou tu viens de poser ta pêche sur mon bureau ?", globalUsername)},
                        {3, string.Format("Je suis désolé {0} , mais je n’ai aucune confiance en des êtres qui peuvent saigner 5 jours sans en crever.", globalUsername)},
                        {4, "Et bien tu auras un F, tu redoublera et plus tard tu videra des fosses sceptiques pour te payer tes doses de cracks."},
                        {5, "Oui une chose est sûre, les femmes peuvent tuer. Les gonzesses ça peut coûter très cher. C'est pour ça que moi les nanas je les saute et je les largue, je leur dis ça va je t'ai assez vu grognasse, barre toi avant de me bouffer la vie."},
                        {6, "Mon pénis a pris la fuite, si vous pouvez essayer de l\'attraper avec un peu de gruyère"},
                        {7, "Rappelons-nous qu'il n\'y a pas de question stupide, seulement des gens stupides"},
                        {8, "Pour résumer, vous êtes les descendants d'un chimpanzé mutant qui a enculé un poisson- écureuil."},
                        {9, "Bordel à queues Monsieur Esclave! J'ai foutu une gerbille dans votre cul et ces cons veulent me remettre une médaille!"},
                        {10, "On dirait que j’ai autre chose que des attardés dans ma classe. N’est-ce pas les enfants ?"},
                        {11, "Au départ, selon cette théorie, on était des poissons. On barbotait tous dans la flotte. Et un jour, un couple de poissons a eu un enfant mal-formé. Et cet enfant mal-formé, bien-que différent, a réussi à survivre. Du coup, ce poisson à la con a fait d’autres poissons mal-formés. Et un jour, un descendant du poisson mal-formé a rampé hors de l’eau avec ses pattes de poisson-mutant. Et il a enculé un écureuil ou je ne sais quoi pour faire ça, une sorte de grenouille-écureuil. Ce truc a eu, à son tour, un enfant mal-formé, un singe-poisson-grenouille. Et ce singe-poisson-grenouille a réussi à enculer un chimpanzé et ce chimpanzé a eu un enfant-mutant qui a sauté un autre chimpanzé. Et ça a donné vous. Pour résumer, vous êtes les descendants d’un chimpanzé-mutant qui a enculé un poisson-écureuil. Mes félicitations !" },
                        {12, string.Format("C’est l’horreur ce qui se passe {0}, je me suis toujours senti à part, j’étais totalement différent des autres, je faisais tâche dans cette ville. Maintenant tous les hétéros ont l’air encore plus gays que moi", globalUsername) },
                        {13, "Mon pénis a pris la fuite, si vous pouvez essayer de l’attraper avec un peu de gruyère" },
                        {14, "Hey les gars, cette beauté va rester une femme ! Qui est-ce qui veut me bourrer la chatte ? Pouvoir aux filles !" },
                        {15, "Les homosexuels c'est le mal, un mal enraciné dans leur cœur noir et froid qui ne pompe pas du sang comme le tien ou le mien mais une sorte de vomi huileux qui circule dans leurs veines pourries et irrigue leur cerveau minuscule ce que provoque chez eux des crises de cannibalisme et un comportement violent. Ai-je été assez clair ?" },
                        {16, "Est-ce qu'il y a un problème les enfants?" },
                        {17, string.Format("Ah vraiment ? {0}, qu'est ce que tu as cette fois? Une autre tumeur à la prostate?", globalUsername)},
                        {18, string.Format("Je ne sais pas {0}, est-ce que tu as demandé à M. Toc?",globalUsername)},
                        {19, "C'EST A MOI QU'TU PARLES?" },
                        {20, "J'ai l'impression que je ne dois pas être le seul à vouloir tuer Kathie Lee Gifford" },
                        {21, "Approche, allez, sale pétasse..!"},
                        {22, "Je fais semblant pour attirer les nanas, trou du cul!" },
                        {23, string.Format("{0}, Stanley peut conduire notre équipe à la victoire contre les cow-boys de middle park pour la première fois depuis 30 ans, il est donc naturel de le traiter mieux que toi parce qu'il vaut mieux que toi",globalUsername) },
                        {24,"Veuillez dire bonjour à Monsieur Esclave"},
                        {25,"Donc Monsieur Esclave est mon assistant culturel, ou comme j'ai coutume de le surnommer : mon assist'encule"},
                        {26,"Ne pensez pas que la fin de l'année scolaire sera facile.Elle sera longue et dure, très très longue, et très très dure."},
                        {27,"Prenez ça Monsieur Esclave!"},
                        {28,"Newton découvrit que pour toute action, il y a réaction, alors que croyez vous qu'il va se passer quand je vais introduire l'élément gerbille dans la chaleur endothermique du cul de Monsieur Esclave? Voyons cela."}

                    };
                    break;
                case BotIdentifier.MonsieurEsclaveID:
                    replies = new Dictionary<int, string>
                    {
                        {1,"OH!"},
                        {2,"Oh! Oh! Ça fait mal!"},
                        {3,"C'est loin d'être le premier animal que je me mets dans le cul"},
                        {4,"Jamais je n'aurais dû mettre tous ces animaux dans mon cul!"},
                        {5,"Oh, je sens qu'on va s'éclater"},
                        {6, "Oh seigneur dieu!"}
                    };
                    break;
                default:
                    replies = new Dictionary<int, string>();
                    break;
            }
            
            return replies;
        }
    }
}


