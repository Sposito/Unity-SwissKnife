public class SubsurfCube{
  private int VertexCounter(int subdiv){
		//Base values for a cube
		int vertex = 8;
		int edge = 12;
		int face = 6;

		for (int i = 0; i < subdiv; i++) {
			//cache for previous values
			int previousEdge = edge;
			int previousFace = face;

			edge = 2 * edge + 4 * previousFace; 
			face = 6 * (int)Mathf.Pow (4, i + 1);
			vertex += previousEdge + previousFace;
		}
		//print ("Vertex: " + vertex + " Edge: " + edge + " Face: " + face);
		return vertex;
	}

}
