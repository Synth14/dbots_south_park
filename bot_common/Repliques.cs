namespace bot_common
{
    public class Repliques
    {
        public Dictionary<int, string> GetEntries(ulong Id, string globalUsername)
        {
            Dictionary<int, string> replies;
            switch (Id)
            {
                case Bot.MonsieurGarrissonID:
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
                        {28,"Newton découvrit que pour toute action, il y a réaction, alors que croyez vous qu'il va se passer quand je vais introduire l'élément gerbille dans la chaleur endothermique du cul de Monsieur Esclave? Voyons cela."},
                        {29,"Et donc maintenant les enfants, au lieu de vous dire rendez-moi vos dessins, je pourrai vous dire \"rendez-moi vos merdes\""},
                        {30,"Je ne sais pas pourquoi, j'ai pris de l'assurance, j'ai pris confiance en moi, j'ai décidé de quitter l'enseignement pour pouvoir faire tout ce que j'ai rêvé de faire : draguer et sauter des gonzesses"},
                        {31, string.Format("Bon sang, je vais vour dire {0}, être un sex-symbol, c'est marrant 5 minutes mais à la longue ça devient fatiguant.", globalUsername)},
                        {32, "Toi tu tais! Tu te tais sinon j'te crève!"},
                        {33, "Je vais emporter un peu d'Eric Roberts dans un doggy-bag, est-ce que quelqu'un d'autre en veut?"},
                        {34,"BZZ, c'est faux! Essaye encore, abruti! HAHAHA HAHAHA!"},
                        {35,"Sales petits ***, où avez-vous mis M. Tock? Mais qu'est ce que vous croyez, bien sûr l'année scolaire est finie pour tous les autres, mais pas pour vous sales petits enfoirés, pas pour vous tant que vous ne m'aurez pas rendu M. Tock!"},
                        {36,"QUOI? Vous me faites des avances ou quoi? Je peux vous assurer que je suis à 100% pas gay du tout. M. Tock d'un autre côté..il a parfois des fantasmes de relations homosexuelles, parfois M.Tock rêve qu'il se retrouve dans un sauna avec Brett fevre, uniquement vêtu d'une canette de bière"},
                        {37,string.Format("C'est ça {0}, désinteresse toi de ce que Barnaby Jones peut t'enseigner, vas-y ne sois pas attentif à ce qu'il dit, nous verrons bien quelle place tu auras plus tard dans la société!",globalUsername)},
                        {38, "Très bien les enfants, je tiens a vous rappeler que c'est un planetarium, pas un bordel de Bangkok alors tenez-vous bien!"},
                        {39, "Hey les mecs! Vous voulez pas qu'on joue à \"j'te pince le cul\"? C'est très drôle, on se court après l'un l'autre et puis on essaye de s'attraper au moins une fesse!"},
                        {40, string.Format("Tiens, c'est marrant, {0} embrasse comme mon père.", globalUsername)},
                        {41,"Ce qu'elles veulent ce sont des histoires de zigounettes, vous croyez qu'elles s'interessent aux détails de l'anatomie féminine? Bien sûr que non! Ce qu'elles veulent c'est qu'on leur parle de bites énormes et puissantes! J'ai vu des femmes lire ce genre de livre, elles feuilletent, elles feuilletent jusqu'au passage où ça parle de pénis, c'est ça qu'elles veulent, alors c'est ça que je leur donne!"}

                    };
                    break;
                case Bot.MonsieurEsclaveID:
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


