using System;
using Comet;

namespace RideTheComet
{
    public class MainPage : View
    {
        readonly State<bool> rememberMe = true;
        readonly State<string> nameValue = "Enter your Name";
        readonly State<string> passwordValue = "Enter your Pwd";
        readonly State<float> securityValue = 0;

        [Body]
        View body() => new VStack
        {
            new HStack
            {
              new Text("User Name:")
                    .Color(Color.Black)
                    .FontSize(20),
              new TextField(nameValue)
            },
            new HStack
            {
                new Text("Password:")
                    .Color(Color.Black)
                    .FontSize(20),
                new TextField(passwordValue)
            },
            new VStack
            {
                new Text("How much do you care about security?"),
                new Slider(value: securityValue, from:0, through:100, by:1f),
                new Text(()=> $"Braveness: {securityValue.Value}")
            }.Padding(top:40),
            new HStack
            {
                new Text("Remember Me:"),
                new Toggle(rememberMe)
            },
            new Button("Login", ()=> {nameValue.Value = string.Empty; passwordValue.Value = string.Empty; securityValue.Value = 0; } )
                .Frame(width:320, height:44)
                .RoundedBorder(20,Color.CadetBlue, 1,false)
                .Background(Color.LightCoral)
                .Color(Color.White)
                .Padding(20)

        }.Padding(left: 20, right:20);
    }
}
