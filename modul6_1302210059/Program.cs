// See https://aka.ms/new-console-template for more information
using modul6_1302210059;

SayaTubeVideo sayaTubeVideo1 = new SayaTubeVideo("Review film Ironman 1 oleh Fadel");
sayaTubeVideo1.IncreasePlayCount(1);
SayaTubeVideo sayaTubeVideo2 = new SayaTubeVideo("Review film Ironman 2 oleh Fadel");
sayaTubeVideo2.IncreasePlayCount(2);
SayaTubeVideo sayaTubeVideo3 = new SayaTubeVideo("Review film Ironman 3 oleh Fadel");
sayaTubeVideo3.IncreasePlayCount(3);
SayaTubeVideo sayaTubeVideo4 = new SayaTubeVideo("Review film Ironman 4 oleh Fadel");
sayaTubeVideo4.IncreasePlayCount(4);
SayaTubeVideo sayaTubeVideo5 = new SayaTubeVideo("Review film Ironman 5 oleh Fadel");
sayaTubeVideo5.IncreasePlayCount(5);
SayaTubeVideo sayaTubeVideo6 = new SayaTubeVideo("Review film Ironman 6 oleh Fadel");
sayaTubeVideo6.IncreasePlayCount(6);
SayaTubeVideo sayaTubeVideo7 = new SayaTubeVideo("Review film Ironman 7 oleh Fadel");
sayaTubeVideo7.IncreasePlayCount(7);
SayaTubeVideo sayaTubeVideo8 = new SayaTubeVideo("Review film Ironman 8 oleh Fadel");
sayaTubeVideo8.IncreasePlayCount(8);
SayaTubeVideo sayaTubeVideo9 = new SayaTubeVideo("Review film Ironman 9 oleh Fadel");
sayaTubeVideo9.IncreasePlayCount(9);
SayaTubeVideo sayaTubeVideo10 = new SayaTubeVideo("Review film Ironman 10 oleh Fadel");
sayaTubeVideo10.IncreasePlayCount(10);



SayaTubeUser sayaTubeUser = new SayaTubeUser("Fadel");
sayaTubeUser.AddVideo(sayaTubeVideo1);
sayaTubeUser.AddVideo(sayaTubeVideo2);
sayaTubeUser.AddVideo(sayaTubeVideo3);
sayaTubeUser.AddVideo(sayaTubeVideo4);
sayaTubeUser.AddVideo(sayaTubeVideo5);
sayaTubeUser.AddVideo(sayaTubeVideo6);
sayaTubeUser.AddVideo(sayaTubeVideo7);
sayaTubeUser.AddVideo(sayaTubeVideo8);
sayaTubeUser.AddVideo(sayaTubeVideo9);
sayaTubeUser.AddVideo(sayaTubeVideo10);


sayaTubeUser.PrintAllVideoPlaycount();
