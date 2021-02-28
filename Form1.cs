using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Paint3
{

    //393
    public partial class Form1 : Form
    {
        int PSize = 12;
        int scenario = 0;
        int first = 0;
        int sx = 0;
        int sy = 0;
        int radiusElipseX = 0;
        int radiusElipseY = 0;
        List<Pixel> tabla = new List<Pixel>();

        int traslacX = 0;
        int traslacY = 0;
        int testVar = 0;
        int groupCount = 0;
        double degree = 90;

        //Assets para traslacion de objetos
        int coordX;
        int coordY;
        int coordXend;
        int coordYend;
        Pixel pixMov = new Pixel(0, 0);


        Color color = Color.Black;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            MakeGridWithMargin();
        }

        public class Pixel
        {
            int posX;
            int posY;
            int group;
            Color Pcolor;


            public Pixel(int posX, int posY, Color color)
            {
                this.posX = posX;
                this.posY = posY;
                this.Pcolor = color;
                this.group = -1;
            }
            public Pixel(int posX, int posY, Color color, int group)
            {
                this.posX = posX;
                this.posY = posY;
                this.Pcolor = color;
                this.group = group;
            }

            public Pixel(int posX, int posY)
            {
                this.posX = posX;
                this.posY = posY;
                this.Pcolor = Color.Black;
            }

            public int getPosX()
            {
                return posX;
            }
            public int getPosY()
            {
                return posY;
            }
            public void setPosX(int posX)
            {
                this.posX = posX;
            }
            public void setPosY(int posY)
            {
                this.posY = posY;
            }
            public Color getColor()
            {
                return Pcolor;
            }

            public void setColor(Color Pcolor)
            {
                this.Pcolor = Pcolor;
            }

            public void setGrupo(int group)
            {
                this.group = group;
            }

            public int getGrupo()
            {
                return group;
            }
        }

        public void Translacion(List<Pixel> puntos, int traslacX, int traslacY)
        {

            this.traslacX += traslacX;
            this.traslacY += traslacY;

            DeleteGrid();
            try
            {
                foreach (var punto in puntos)
                {
                    paintSinAgregar((float)(punto.getPosX() + this.traslacX) * PSize, (float)(punto.getPosY() + this.traslacY) * PSize, punto);
                }
            }
            catch (Exception e)
            {
                buttonTest.Text = (e.Message);
            }
        }

        private void resetTraslacion()
        {

            this.traslacX = 0;
            this.traslacY = 0;

            DeleteGrid();
            try
            {
                foreach (var punto in tabla)
                {
                    paintSinAgregar((float)(punto.getPosX() + this.traslacX) * PSize, (float)(punto.getPosY() + this.traslacY) * PSize, punto);
                }
            }
            catch (Exception e)
            {
                buttonTest.Text = (e.Message);
            }
        }

        private void RedibujarPuntos(List<Pixel> puntos)
        {
            try
            {
                foreach (var punto in puntos)
                {
                    paintSinAgregar((float)(punto.getPosX() + traslacX) * PSize, (float)(punto.getPosY() + traslacY) * PSize, punto);
                }
            }
            catch (Exception e)
            {
                buttonTest.Text = ("Error en Redibujado");
            }
        }

        private void MakeGrid()
        {
            Pen pen = new Pen(Color.Black, 1);
            Graphics g = panel1.CreateGraphics();

            float width = panel1.Size.Width;
            float height = panel1.Size.Height;
            for (int i = 0; i <= height; i += PSize)
            {
                g.DrawLine(pen, i, 0, i, height);
                g.DrawLine(pen, 0, i, width, i);
            }
            g.Dispose();
            SizeLabel.Text = "Pizel Size: " + PSize;
        }

        private void MakeGridWithMargin()
        {
            Pen pen = new Pen(Color.Black, 1);
            Graphics g = panel1.CreateGraphics();

            float width = panel1.Size.Width;
            float height = panel1.Size.Height;
            for (int i = 0; i <= height; i += PSize)
            {
                g.DrawLine(pen, i, 0, i, height);
                g.DrawLine(pen, 0, i, width, i);
            }
            g.Dispose();
            SizeLabel.Text = "Pizel Size: " + PSize;
            groupCount = -2;
            DDALine(0 * PSize, 0 * PSize, 59 * PSize, 0 * PSize);
            DDALine(0 * PSize, 0 * PSize, 0 * PSize, 64 * PSize);
            DDALine(0 * PSize, 64 * PSize, 59 * PSize, 64 * PSize);
            DDALine(59 * PSize, 0 * PSize, 59 * PSize, 64 * PSize);
            groupCount = 0;
        }



        private void panel1_Click(object sender, EventArgs e)
        {

            Point point = panel1.PointToClient(Cursor.Position);

            switch (scenario)
            {
                case 0: //Single Pixel draw


                    paint(point.X, point.Y, color);
                    groupCount++;

                    break;

                case 1: //Draw DDALine

                    if (first == 0)
                    {
                        sx = point.X;
                        sy = point.Y;
                        paint(sx, sy, color);
                        first = 1;
                    }
                    else
                    {
                        int ex = point.X;
                        int ey = point.Y;
                        DDALine(sx, sy, ex, ey);

                        first = 0;
                        groupCount++;
                    }

                    
                    break;

                case 2: //Draw BresenhamLine

                    if (first == 0)
                    {
                        sx = point.X;
                        sy = point.Y;
                        paint(sx, sy, color);
                        first = 1;
                    }
                    else
                    {
                        int ex = point.X;
                        int ey = point.Y;
                        BresenhamLineDraw(sx, sy, ex, ey);

                        first = 0;
                        groupCount++;
                    }
                    
                    break;

                case 3: //Draw BresenhamCircle

                    if (first == 0)
                    {
                        sx = point.X;
                        sy = point.Y;
                        paint2(sx, sy);
                        first = 1;
                    }
                    else
                    {
                        int ex = point.X;
                        int ey = point.Y;
                        BresenhamCircleDraw(sx, sy, RadiusCalc(sx, sy, ex, ey));

                        first = 0;
                    }
                    groupCount++;
                    break;

                case 4: //Draw Elipse

                    if (first == 0)
                    {
                        sx = point.X;
                        sy = point.Y;
                        paint2(sx, sy);
                        first = 1;
                    }
                    else if (first == 1)
                    {
                        int ex = point.X;
                        int ey = point.Y;
                        if (Math.Abs(ex - sx) > Math.Abs(ey - sy))
                        {
                            radiusElipseX = RadiusCalc(sx, sy, ex, ey);
                        }
                        else
                        {
                            radiusElipseY = RadiusCalc(sx, sy, ex, ey);
                        }

                        first = 2;
                    } else
                    {
                        int ex = point.X;
                        int ey = point.Y;
                        if (radiusElipseY == 0)
                        {
                            radiusElipseY = RadiusCalc(sx, sy, ex, ey);
                        }
                        else
                        {
                            radiusElipseX = RadiusCalc(sx, sy, ex, ey);
                        }

                        DrawElipse(radiusElipseX, radiusElipseY, sx, sy);
                        radiusElipseX = 0;
                        radiusElipseY = 0;
                        first = 0;
                    }
                    groupCount++;
                    break;

                case 5: //FloodPaint
                    Pixel p = new Pixel(point.X, point.Y, color);
                    int pos = tabla.IndexOf(p);
                    if (pos != -1)
                    {
                        Pixel p2 = tabla[pos];
                        floodPaint(point.X / PSize, point.Y / PSize, p2.getColor(), true);

                    }
                    else
                    {
                        floodPaint(point.X / PSize, point.Y / PSize, Color.White, true);
                    }

                    groupCount++;

                    break;
                case 6: //Move Group

                    if (first == 0)
                    {
                        coordX = point.X / PSize;
                        coordY = point.Y / PSize;
                        pixMov.setPosX(coordX - traslacX);
                        pixMov.setPosY(coordY - traslacY);
                        if (isRepetido(tabla, pixMov))
                        {
                            first++;
                            labelTest.Text = "Punto Elegido "+coordX+" , "+coordY;
                        }
                        else
                        {
                            labelTest.Text = "No hay un punto aca " + coordX + " , " + coordY;
                        }
                    }
                    else
                    {
                        coordXend = point.X / PSize;
                        coordYend = point.Y / PSize;
                        moverConjunto(coordXend - coordX, coordYend - coordY, getPunto(tabla, pixMov).getGrupo());
                        first = 0;
                        labelTest.Text = "Movido a " + coordXend + " , " + coordYend;
                    }

                    break;
                case 7: //Scale Up
                    coordX = point.X / PSize;
                    coordY = point.Y / PSize;
                    pixMov.setPosX(coordX - traslacX);
                    pixMov.setPosY(coordY - traslacY);
                    if (isRepetido(tabla, pixMov))
                    {                     
                        labelTest.Text = "Punto Elegido " + coordX + " , " + coordY;
                        EscalarConjunto(getPunto(tabla, pixMov).getGrupo());
                    }
                    else
                    {
                        labelTest.Text = "No hay un punto aca " + coordX + " , " + coordY;
                    }
                    
                    break;
                case 8: //Scale Down
                    coordX = point.X / PSize;
                    coordY = point.Y / PSize;
                    pixMov.setPosX(coordX - traslacX);
                    pixMov.setPosY(coordY - traslacY);
                    if (isRepetido(tabla, pixMov))
                    {
                        labelTest.Text = "Punto Elegido " + coordX + " , " + coordY;
                        EscalarConjuntoMedio(getPunto(tabla, pixMov).getGrupo());
                    }
                    else
                    {
                        labelTest.Text = "No hay un punto aca " + coordX + " , " + coordY;
                    }

                    break;
                case 9: //Rotate
                    coordX = point.X / PSize;
                    coordY = point.Y / PSize;
                    pixMov.setPosX(coordX - traslacX);
                    pixMov.setPosY(coordY - traslacY);
                    if (isRepetido(tabla, pixMov))
                    {
                        labelTest.Text = "Punto Elegido " + coordX + " , " + coordY;
                        RotarFigura(getPunto(tabla, pixMov).getGrupo(), coordX, coordY);
                    }
                    else
                    {
                        labelTest.Text = "No hay un punto aca " + coordX + " , " + coordY;
                    }

                    break;

            }

        }

        private void RotarFigura(int grupo, int cx, int cy)
        {
            foreach (var punto in tabla)
            {
                if (punto.getGrupo() == grupo)
                {
                    double newX = (punto.getPosX() - cx) * Math.Cos(degree * Math.PI / 180) - (punto.getPosY()- cy) * Math.Sin(degree * Math.PI / 180) + cx - traslacX - traslacY;
                    double newY = (punto.getPosX() - cx) * Math.Sin(degree * Math.PI / 180) + (punto.getPosY()- cy) * Math.Cos(degree * Math.PI / 180) + cy - traslacX - traslacY;
                    punto.setPosX((int)Math.Round(newX));
                    punto.setPosY((int)Math.Round(newY));
                }
            }
            DeleteGrid();
            RedibujarPuntos(tabla);
        }

        private void moverConjunto(int traslacionX, int traslacionY, int grupo)
        {
            foreach (var punto in tabla)
            {
                if (punto.getGrupo() == grupo)
                {
                    punto.setPosX(traslacionX + punto.getPosX());
                    punto.setPosY(traslacionY + punto.getPosY());
                }
            }
            DeleteGrid();
            RedibujarPuntos(tabla);
        }
        private void EscalarConjunto(int grupo)
        {
            List<Pixel> tablaNew = new List<Pixel>();
            Pixel pix = new Pixel(0, 0);
            int add = 0;
            foreach (var punto in tabla)
            {

                if (punto.getGrupo() == grupo)
                {

                    tablaNew.Add(new Pixel(2 * punto.getPosX(), 2 * punto.getPosY(), punto.getColor(), punto.getGrupo()));
                    tablaNew.Add(new Pixel(2 * punto.getPosX()+1, 2 * punto.getPosY(), punto.getColor(), punto.getGrupo()));
                    tablaNew.Add(new Pixel(2 * punto.getPosX(), 2 * punto.getPosY()+1, punto.getColor(), punto.getGrupo()));
                    tablaNew.Add(new Pixel(2 * punto.getPosX()+1, 2 * punto.getPosY()+1, punto.getColor(), punto.getGrupo()));
                    add += 4;
                }
                else 
                {
                    pix = punto;
                    tablaNew.Add(pix);
                    add++;
                }
            }

            tabla.Clear();
            tabla.AddRange(tablaNew);
            labelTest.Text = "Total agregados " + add + "tamano tablanew " + tablaNew.Count()+"tamano tablaAct "+tabla.Count();
            DeleteGrid();
            RedibujarPuntos(tabla);
        }

        private void EscalarConjuntoMedio(int grupo)
        {
            List<Pixel> tablaNew = new List<Pixel>();
            Pixel pix = new Pixel(0, 0);
            int add = 0;
            foreach (var punto in tabla)
            {

                if (punto.getGrupo() == grupo)
                {
                    if (!isRepetido(tablaNew, new Pixel(punto.getPosX() / 2, punto.getPosY() / 2, punto.getColor(), punto.getGrupo())))
                    {
                        tablaNew.Add(new Pixel(punto.getPosX() / 2, punto.getPosY() / 2, punto.getColor(), punto.getGrupo()));
                        add += 1;
                    }
                }
                else
                {
                    pix = punto;
                    tablaNew.Add(pix);
                    add++;
                }
            }

            tabla.Clear();
            tabla.AddRange(tablaNew);
            labelTest.Text = "Total agregados " + add + "tamano tablanew " + tablaNew.Count() + "tamano tablaAct " + tabla.Count();
            DeleteGrid();
            RedibujarPuntos(tabla);
        }

        private void floodFill(int x, int y, Color bkg)
        {
            Pixel p = new Pixel(x, y, bkg, groupCount);

            if (isRepetidoYMismoColorYRepintar(tabla, p))
            {
                paint(x * PSize, y * PSize, color);
                p.setPosX(x + 1);
                if (isRepetidoYMismoColor(tabla,p))
                {
                    floodFill(x + 1, y, bkg);
                }
                p.setPosX(x - 1);
                if (isRepetidoYMismoColor(tabla, p))
                {
                    floodFill(x - 1, y, bkg);
                }
                p.setPosX(x);
                p.setPosY(y - 1);
                if (isRepetidoYMismoColor(tabla, p))
                {
                    floodFill(x, y - 1, bkg);
                }
                p.setPosY(y + 1);
                if (isRepetidoYMismoColor(tabla, p))
                {
                    floodFill(x, y + 1, bkg);
                }                  
            }
            
            RedibujarPuntos(tabla);
        }

        private void floodPaint(int x, int y, Color bkg, bool firstRun)
        {
            Pixel p = new Pixel(x - traslacX, y - traslacY, bkg);

            if (isRepetido(tabla, p))
            {
                if (firstRun)
                {
                    floodFill(x, y, GetColorPix(tabla,p));
                }
            }
            else 
            {
                paint(x * PSize, y * PSize, color);
                floodPaint(x, y + 1, bkg, false);
                floodPaint(x, y - 1, bkg, false);
                floodPaint(x + 1, y, bkg, false);
                floodPaint(x - 1, y, bkg, false);    
            }
        }

        private Pixel getPunto(List<Pixel> puntos, Pixel pix)
        {
            foreach (var punto in puntos)
            {
                if (pix.getPosX() == punto.getPosX())
                {
                    if (pix.getPosY() == punto.getPosY())
                    {
                        return punto;
                    }
                }
            }
            labelTest.Text = "x " + pix.getPosX() + "y " + pix.getPosY()+ "B "+ isRepetido(tabla,pix);
            return pix;
        }

        private bool isRepetido(List<Pixel> puntos, Pixel pix)
        {
            foreach (var punto in puntos)
            {
                if (pix.getPosX() == punto.getPosX())
                {
                    if (pix.getPosY() == punto.getPosY())
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private bool isRepetidoYMismoColor(List<Pixel> puntos, Pixel pix)
        {
            foreach (var punto in puntos)
            {
                if (pix.getPosX() == punto.getPosX())
                {
                    if (pix.getPosY() == punto.getPosY())
                    {
                        if (Color.Equals(punto.getColor(), pix.getColor()))
                        {
                            return true;
                        }                        
                    }
                }
            }
            return false;
        }

        private bool isRepetidoYMismoColorYRepintar(List<Pixel> puntos, Pixel pix)
        {
            foreach (var punto in puntos)
            {
                if (pix.getPosX() == punto.getPosX())
                {
                    if (pix.getPosY() == punto.getPosY())
                    {
                        if (Color.Equals(punto.getColor(), pix.getColor()))
                        {
                            punto.setColor(color);
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        private Color GetColorPix(List<Pixel> puntos, Pixel pix)
        {
            foreach (var punto in puntos)
            {
                if (pix.getPosX() == punto.getPosX())
                {
                    if (pix.getPosY() == punto.getPosY())
                    {
                        return punto.getColor();
                    }
                }
            }
            return Color.Black;
        }
        
        private void paint(float Xpos, float Ypos, Color colorAct)
        {
            

            int x = (int)Xpos / PSize * PSize;
            int y = (int)Ypos / PSize * PSize;

            x = x / PSize;
            y = y / PSize;

            Pixel p = new Pixel(x - traslacX, y - traslacY, colorAct, groupCount);

            if (isRepetido(tabla,p))
            {
                testVar++;
            }
            else 
            {
                SolidBrush sb = new SolidBrush(colorAct);
                Graphics g = panel1.CreateGraphics();
                tabla.Add(p);
                g.FillRectangle(sb, x * PSize, y * PSize, PSize, PSize);
                sb.Dispose();
                g.Dispose();
            }
        }

        private void paintSinAgregar(float Xpos, float Ypos, Pixel pix)
        {
            int x = (int)Xpos / PSize * PSize;
            int y = (int)Ypos / PSize * PSize;

            x = x / PSize;
            y = y / PSize;

            Pixel p = new Pixel(x, y, pix.getColor());


            SolidBrush sb = new SolidBrush(p.getColor());
            Graphics g = panel1.CreateGraphics();
            g.FillRectangle(sb, x * PSize, y * PSize, PSize, PSize);
            sb.Dispose();
            g.Dispose();
        }

        private void paint2(int Xpos, int Ypos)
        {
            SolidBrush sb = new SolidBrush(Color.Red);
            Graphics g = panel1.CreateGraphics();

            int x = Xpos / PSize * PSize;
            int y = Ypos / PSize * PSize;

            g.FillRectangle(sb, x, y, PSize, PSize);
            sb.Dispose();
        }

        private void DDALine(int sx, int sy, int ex, int ey)
        {
            int dx = ex - sx;
            int dy = ey - sy;
            int steps;
            if(Math.Abs(dx) > Math.Abs(dy))
            {
                steps = Math.Abs(dx);
            }
            else
            {
                steps = Math.Abs(dy);
            }

            float xinc = dx / (float)steps;
            float yinc = dy / (float)steps;

            float x = sx;
            float y = sy;

            for (int i = 0; i <= steps; i++)
            {
                paint(x,y, color);
                x += xinc;
                y += yinc;

            }

        }

        private int RadiusCalc(int sx, int sy, int ex, int ey)
        {
            double radius;

            int x = ex - sx;
            int y = ey - sy;

            radius = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y,2));

            return (int)radius;
        }

        private void BresenhamLineDraw(int sx, int sy, int ex, int ey)
        {
            int w = ex - sx;
            int h = ey - sy;
            int dx1 = 0, dy1 = 0, dx2 = 0, dy2 = 0;
            if (w < 0) dx1 = -1; else if (w > 0) dx1 = 1;
            if (h < 0) dy1 = -1; else if (h > 0) dy1 = 1;
            if (w < 0) dx2 = -1; else if (w > 0) dx2 = 1;
            int longest = Math.Abs(w);
            int shortest = Math.Abs(h);
            if (!(longest > shortest))
            {
                longest = Math.Abs(h);
                shortest = Math.Abs(w);
                if (h < 0) dy2 = -1; else if (h > 0) dy2 = 1;
                dx2 = 0;
            }
            int numerator = longest ;
            for (int i = 0; i <= longest; i++)
            {
                paint(sx,sy, color);
                numerator += shortest;
                if (!(numerator < longest))
                {
                    numerator -= longest;
                    sx += dx1;
                    sy += dy1;
                }
                else
                {
                    sx += dx2;
                    sy += dy2;
                }
            }
        }

        

        private void BresenhamCircleDraw(int xc, int yc, int r)
        {
            int x = 0, y = r;
            int d = 3 - 2 * r;
            drawCircle(xc, yc, x, y);
            while (y >= x)
            {
                x++;
                if (d > 0)
                {
                    y--;
                    d = d + 4 * (x - y) + 10;
                }
                else
                    d = d + 4 * x + 6;
                drawCircle(xc, yc, x, y);
            }
        }

        private void drawCircle(int xc, int yc, int x, int y)
        {
            paint(xc + x, yc + y, color);
            paint(xc - x, yc + y, color);
            paint(xc + x, yc - y, color);
            paint(xc - x, yc - y, color);
            paint(xc + y, yc + x, color);
            paint(xc - y, yc + x, color);
            paint(xc + y, yc - x, color);
            paint(xc - y, yc - x, color);
        }

        public void DrawElipse(float rx, float ry,
                        float xc, float yc)
        {

            float dx;
            float dy;
            float d1;
            float d2;
            float x;
            float y;
            x = 0;
            y = ry;

            //decision region 1 
            d1 = (ry * ry) - (rx * rx * ry) +
                            (0.25f * rx * rx);
            dx = 2 * ry * ry * x;
            dy = 2 * rx * rx * y;

            // For region 1 
            while (dx < dy)
            {
                paint((x + xc), (y + yc), color);
                paint((-x + xc), (y + yc), color);
                paint((x + xc), (-y + yc), color);
                paint((-x + xc), (-y + yc), color);
                // Checking and updating value of 
                // decision parameter based on algorithm 
                if (d1 < 0)
                {
                    x++;
                    dx = dx + (2 * ry * ry);
                    d1 = d1 + dx + (ry * ry);
                }
                else
                {
                    x++;
                    y--;
                    dx = dx + (2 * ry * ry);
                    dy = dy - (2 * rx * rx);
                    d1 = d1 + dx - dy + (ry * ry);
                }
            }

            // Decision region 2 
            d2 = ((ry * ry) * ((x + 0.5f) * (x + 0.5f)))
                + ((rx * rx) * ((y - 1) * (y - 1)))
                - (rx * rx * ry * ry);

            // Plotting points of region 2 
            while (y >= 0)
            {
                paint((x + xc), (y + yc), color);
                paint((-x + xc), (y + yc), color);
                paint((x + xc), (-y + yc), color);
                paint((-x + xc), (-y + yc), color);

                // Checking and updating parameter 
                // value based on algorithm 
                if (d2 > 0)
                {
                    y--;
                    dy = dy - (2 * rx * rx);
                    d2 = d2 + (rx * rx) - dy;
                }
                else
                {
                    y--;
                    x++;
                    dx = dx + (2 * ry * ry);
                    dy = dy - (2 * rx * rx);
                    d2 = d2 + dx - dy + (rx * rx);
                }
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            tabla.Clear();
            DeleteGridWithRedraw();
        }

        private void DeleteGrid()
        {
            Pen pen = new Pen(Color.Black, 1);
            SolidBrush sb = new SolidBrush(Color.White);
            Graphics g = panel1.CreateGraphics();

            float width = panel1.Size.Width;
            float height = panel1.Size.Height;

            g.FillRectangle(sb, 0, 0, width, height);

            for (int i = 0; i <= height; i += PSize)
            {
                g.DrawLine(pen, i, 0, i, height);
                g.DrawLine(pen, 0, i, width, i);

            }
            //MakeGridWithMargin();
            g.Dispose();
            sb.Dispose();
        }

        private void DeleteGridWithRedraw()
        {
            Pen pen = new Pen(Color.Black, 1);
            SolidBrush sb = new SolidBrush(Color.White);
            Graphics g = panel1.CreateGraphics();

            float width = panel1.Size.Width;
            float height = panel1.Size.Height;

            g.FillRectangle(sb, 0, 0, width, height);

            for (int i = 0; i <= height; i += PSize)
            {
                g.DrawLine(pen, i, 0, i, height);
                g.DrawLine(pen, 0, i, width, i);

            }
            MakeGridWithMargin();
            g.Dispose();
            sb.Dispose();
        }

        private void ColorSelect_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                color = colorDialog1.Color;
                ColorBox.BackColor = colorDialog1.Color;
            }
        }

        private void SizeBar_Scroll(object sender, EventArgs e)
        {
            PSize = SizeBar.Value;

            DeleteGrid();
            MakeGrid();
            RedibujarPuntos(tabla);
        }

        private void drawPixel_CheckedChanged(object sender, EventArgs e)
        {
            scenario = 0;
        }

        private void drawDDALine_CheckedChanged(object sender, EventArgs e)
        {
            scenario = 1;
        }
        private void BresenhamLine_CheckedChanged(object sender, EventArgs e)
        {
            scenario = 2;
        }

        private void BresenhamCircle_CheckedChanged(object sender, EventArgs e)
        {
            scenario = 3;
        }

        private void Elipse_CheckedChanged(object sender, EventArgs e)
        {
            scenario = 4;
        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            Translacion(tabla,50,50);
        }

        private void FloodPaint_CheckedChanged(object sender, EventArgs e)
        {
            scenario = 5;
        }
        private void TranslateDrawing_CheckedChanged(object sender, EventArgs e)
        {
            scenario = 6;
        }

        private void buttonUp_Click(object sender, EventArgs e)
        {
            Translacion(tabla, 0, -1);
        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {
            Translacion(tabla, -1, 0);
        }

        private void buttonDown_Click(object sender, EventArgs e)
        {
            Translacion(tabla, 0, 1);
        }

        private void buttonRight_Click(object sender, EventArgs e)
        {
            Translacion(tabla, 1, 0);
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            resetTraslacion();
        }

        private void radioButtonScale2X_CheckedChanged(object sender, EventArgs e)
        {
            scenario = 7;
        }

        private void radioButtonScale05X_CheckedChanged(object sender, EventArgs e)
        {
            scenario = 8;
        }

        private void Rotate90Right_CheckedChanged(object sender, EventArgs e)
        {
            scenario = 9;
            degree = 90;
        }

        private void Rotate90Left_CheckedChanged(object sender, EventArgs e)
        {
            scenario = 9;
            degree = -90;
        }
    }
}
