using System;

public class IntPair  {
	public int x, y;

	public readonly static IntPair up    = new IntPair( 0, 1);
	public readonly static IntPair right = new IntPair( 1, 0);
	public readonly static IntPair down  = new IntPair( 0,-1);
	public readonly static IntPair left  = new IntPair(-1, 0);
	public readonly static IntPair zero  = new IntPair( 0, 0);
	public readonly static IntPair one   = new IntPair( 1, 1);


	public IntPair(int x, int y){
		this.x = x;
		this.y = y;
	}

	public static IntPair operator + (IntPair p1, IntPair p2){
		return new IntPair (p1.x + p2.x, p1.y + p2.y);
	}

	public static IntPair operator * (IntPair p1, int m){
		return new IntPair (p1.x * m, p1.y * m);
	}

	public static IntPair operator * (int m ,IntPair p1){
		return new IntPair (p1.x * m, p1.y * m);
	}

	public override string ToString(){
		return("(" + x + ", " + y + ")");
	}
		
}
