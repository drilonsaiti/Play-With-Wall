# PLAY WITH WALL

Главаната идеја на проектот/играта е да биде забавна за играње, и е креиран преку Windows Forms Application.Идејата за оваа игра доаѓа од тоа што ако сакаме да подобруваме играњето со топка(футбал) ова метода е најдобрата.

### Development

Главната сцена е сцена која ги прикажува сите можни копчиња за започнување на играта, како што се промена на стапалото, quit, pause, продолжување, restart

![MainScreen](https://user-images.githubusercontent.com/50522333/130507663-eb46a141-dff3-49f5-a690-9e4d6a57c140.png)

Ако го стисниме Space играта се паузира и после преку Enter може да продолжиме.

![PausedScreen](https://user-images.githubusercontent.com/50522333/130507671-ed722f09-cf0b-447b-b698-cad77654dc29.png)



### Gameplay

Првично, апликацијата започнува со форма во која корисникот ќе може да чита информации и команда за игра.

Играта започнува кога корисникот ќе притисне стрелка десно или лево.

Играта се игра преку движење на глуче.Главната идејата е да бидиме спремни секогаш да ја удириме топка, кога ја промашуваме тогаш тоа значи дека изгувиме.

Кога ја удираме топката со нога, топката оди до sид и повторно се враќа кај нас.

Едно нешто што ја прави играта поинтересна е тоа што можеме да ја смениме страната на стапалото. Играчите мора да внимаваат да немаат погрешна нога во моментот кога ќе дојде топката.Исто така, по секој удар на топката, неговата брзина се зголемува.

### Results 

На крајот, откако ќе заврши играта, можеме да ја видиме сцената со резултати.Исто така резултатот е прикажан и на левата страна за време на играта, каде што по секој удар поените се зголемуваат.

![sccoreEnd](https://user-images.githubusercontent.com/50522333/130507696-6fb5f936-6244-436a-9126-c0f5fa64c776.png)



### Implementation

Ова е класата чија задача е да ги имплементира sидовите (пречките) на сцената.

```c#
    public class Wall
    {
        public Image wallTop;
        public Image wallLeft;
        public Image wallRight;
        public Image wallBottom;

        public Wall()
        {
            wallTop = Properties.Resources.wallTop;
            wallLeft = Properties.Resources.wallSide;
            wallRight = Properties.Resources.wallSide;
            wallBottom = Properties.Resources.wallTop;
        }

        public void drawTopWall(Graphics g)
        {
            g.DrawImage(wallTop, -2, 3, 1060, 15);
        }

        public void drawLeftWall(Graphics g)
        {
            g.DrawImage(wallLeft, -1, 4, 15, 620);
        }

        public void drawRightWall(Graphics g)
        {
            g.DrawImage(wallRight, 1044, 4, 15, 620);
        }

        public void drawBottomWall(Graphics g)
        {
            g.DrawImage(wallBottom, 3, 604, 1060, 15);
        }
    }
```

Ова е класата чија задача е да ги имплементира стапалото на сцената.

```c#
  public class Foot
    {
        public Image Image { get; set; }

        public Foot()
        {

        }

        public Image getLeftSide()
        {
            Image = Properties.Resources.leftFoott;
            return Image;
        }

        public Image getRightSide()
        {
            Image = Properties.Resources.rightfooots;
            return Image;
        }

        public Image getImage()
        {
            return Image;
        }
    }
```

Изгледот и движењето на стапалото прикажани подолу:

![foot](https://user-images.githubusercontent.com/50522333/130507708-4d6f28fa-c2a7-4bef-9c5e-de8c4ae8a03a.gif)

```c#
 public class Ball
    {

        public Image Image { get; set; }

        public Ball()
        {
            Image = Properties.Resources.ball;
        }

        public Image getImage()
        {
            return Image;
        }
    }
```

![ball](https://user-images.githubusercontent.com/50522333/130507804-6dc21b1d-e8d0-4e67-9eed-b29b03b3a2f3.gif)

# Demonstration of Playing the Game 

![completGame](https://user-images.githubusercontent.com/50522333/130507388-f0ead7c9-174f-4853-a7dc-43f107c02ace.gif)



