class planoCartesiano{

    private int x;
    private int y;

    public planoCartesiano()
    {

    }
    public planoCartesiano(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    public void setX(int x)
    {
        this.x = x;
    }
     public void setY(int y)
    {
        this.y = y;
    }
    public int getX()
    {
        return x;
    }
    public int getY()   
    {
        return y;
    }

    public void montarPlanoCartesiano()
    {
        
          for(int i = 6; i > -7; i--)
            {
                for(int j = -6; j < 7; j++)
                {
                    if(i == 0 && j == 0)
                    {
                        Console.Write("+");
                    }else if (i == 0)
                    {
                        Console.Write("-");
                    }else if(j == 0)
                    {
                        Console.Write("|");
                    }else if(i == y && j == x)
                    {
                        Console.Write("o");
                    }else
                    {
                         Console.Write(" ");
                    }
                    
                }
              Console.WriteLine();
            }
        
        
    }




}