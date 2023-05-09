using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextGame.Unit
{
    abstract class Unit
    {
        private int hP;
        public int HP { get {  return hP; } }
        private int aTK;
        public int ATK { get { return aTK; } }
        public string image;
        // A* 알고리즘
        // 다익스트라 알고리즘을 확장하여 만든 최단경로 탐색 알고리즘
        // 경로 탐색의 우선순위를 두고 유망한 해부터 우선적으로 탐색
        private class ASNode
        {
            public GameManager.Point point; // 현재 정점 위치
            public GameManager.Point? parent; // 이 정점을 탐색한 정점
            public int f; // g+h 총거리
            public int g; // 쳔재까지의 거리, 지금까지 경로 가중치
            public int h; // 휴리스틱: 앞으로 예상되는 거리, 목표까지 추정 경로 가중치
            public ASNode(GameManager.Point point, GameManager.Point? parent, int g, int h)
            {
                this.point = point;
                this.parent = parent;
                this.g = g;
                this.h = h;
                this.f = g + h;
            }
        }
        const int CostStraight = 10;
        const int CostDiagonal = 14;
        static GameManager.Point[] Direction =
        {
        new GameManager.Point (0, +1), // 상
        new GameManager.Point (0, -1), // 하
        new GameManager.Point (-1, 0), // 좌
        new GameManager.Point (+1, 0), // 우
        new GameManager.Point( -1, +1 ), // 좌상
		new GameManager.Point( -1, -1 ), // 좌하
		new GameManager.Point( +1, +1 ), // 우상
		new GameManager.Point( +1, -1 )	 // 우하
        };
        public static bool PathFinding(char[,] tileMap, GameManager.Point start, GameManager.Point end, out List<GameManager.Point> path)
        {
            int ySize = tileMap.GetLength(0);
            int xSize = tileMap.GetLength(1);

            bool[,] visited = new bool[ySize, xSize];
            ASNode[,] nodes = new ASNode[ySize, xSize];
            PriorityQueue<ASNode, int> nextPointPQ = new PriorityQueue<ASNode, int>();

            // 0. 시작 정점을 생성하여 추가
            ASNode startNode = new ASNode(start, null, 0, Heuristic(start, end, tileMap[start.y, start.x]));
            nodes[startNode.point.y, startNode.point.x] = startNode;
            nextPointPQ.Enqueue(startNode, startNode.f);
            while (nextPointPQ.Count > 0)
            {
                // 1. 다음으로 탐색할 정점 꺼내기
                ASNode nextNode = nextPointPQ.Dequeue();

                // 2. 방문한 정점은 방문표시
                visited[nextNode.point.y, nextNode.point.x] = true;

                // 3. 탐색할 정점이 도착지인 경우
                // 도착했다고 판단해서 경로 반환
                if (nextNode.point.x == end.x && nextNode.point.y == end.y)
                {
                    GameManager.Point? pathPoint = end;
                    path = new List<GameManager.Point>();
                    while (pathPoint != null)
                    {
                        GameManager.Point point = pathPoint.GetValueOrDefault();
                        path.Add(point);
                        pathPoint = nodes[point.y, point.x].parent;
                    }
                    path.Reverse();
                    return true;
                }
                // 4. Astar 탐색을 진행
                // 방향 탐색
                for (int i = 0; i < Direction.Length; i++)
                {
                    int x = nextNode.point.x + Direction[i].x;
                    int y = nextNode.point.y + Direction[i].y;

                    // 4-1. 탐색하면 안되는 경우 제외
                    // 맵을 벗어났을 경우
                    if (x < 0 || x >= xSize || y < 0 || y > +ySize)
                    {
                        continue;
                    }
                    // 탐색할 수 없는 정점일 경우 (벽같은)
                    else if (tileMap[y, x] == '■' || tileMap[y, x] == '♣')
                    {
                        continue;
                    }
                    // 이미 방문한 정점일 경우
                    else if (visited[y, x])
                    {
                        continue;
                    }
                    // 4-2. 점수 계산
                    int g = nextNode.g + ((nextNode.point.x == x || nextNode.point.y == y) ? CostStraight : CostDiagonal);
                    int h = Heuristic(new GameManager.Point(x, y), end, tileMap[y, x]);
                    ASNode newNode = new ASNode(new GameManager.Point(x, y), nextNode.point, g, h);
                    // 4-3. 정점의 갱신이 필요한 경우 새로운 정점으로 할당
                    if (nodes[y, x] == null || // 점수계산이 되지 않은 정점이거나
                        nodes[y, x].f > newNode.f) // 가중치가 더 높은 정점인 경우
                    {
                        nodes[y, x] = newNode;
                        nextPointPQ.Enqueue(newNode, newNode.f);
                    }
                }
            }
            path = null;
            return false;
        }
        // 중요
        // 휴리스틱 (Heuristic) : 최상의 경로를 추정하는 순위값, 휴리스틱에 의해 경로탐색 효율이 결정됨
        private static int Heuristic(GameManager.Point start, GameManager.Point end, char tile)
        {
            int xSize = Math.Abs(start.x - end.x);
            int ySize = Math.Abs(start.y - end.y);
            // 맨해튼 거리 : 가로 세로를 통해 이동하는 거리
            // return CostStraight * (xSize + ySize);

            // 유클리드 거리 : 대각선을 통해 이동하는 거리
            if (tile == '♨')
            {
                return (CostStraight * (int)Math.Sqrt(xSize * xSize + ySize * ySize)) << 1;
            }
            return CostStraight * (int)Math.Sqrt(xSize * xSize + ySize * ySize);
        }
    }
}
