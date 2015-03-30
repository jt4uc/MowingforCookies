using System;

public class Tile
{
   public int firstgid;
   public int lastgid;
   public String name;
   public String source;
   public int tileWidth;
   public int tileHeight;
   public int imageWidth;
   public int imageHeight;
   //public BitmapData bitmapData;
   public int tileAmountWidth;
   
 
   public Tile(int firstgid, String name, int tileWidth, int tileHeight, String source, int imageWidth, int imageHeight)
   {
      this.firstgid = firstgid;
      this.name = name;
      this.tileWidth = tileWidth;
      this.tileHeight = tileHeight;
      this.source = source;
      this.imageWidth = imageWidth;
      this.imageHeight = imageHeight;
      // some casting craziness here, because apparently Math.Floor returns a double...
      tileAmountWidth = (int) Math.Floor((double)imageWidth / tileWidth);
      lastgid = (int) (tileAmountWidth * Math.Floor((double)imageHeight / tileHeight)) + firstgid - 1;
      
   }
}

