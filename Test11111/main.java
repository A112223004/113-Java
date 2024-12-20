public class main {
    import manager.MatchManager;
    import models.Player;

    public class Main {
        public static void main(String[] args) {
            MatchManager manager = new MatchManager();

            // 註冊玩家
            Player player1 = new Player(1, "Alice", 1500);
            Player player2 = new Player(2, "Bob", 1600);
            manager.registerPlayer(player1);
            manager.registerPlayer(player2);

            // 加入匹配
            manager.joinMatch(player1);
            manager.joinMatch(player2);

            // 匹配玩家並建立房間
            manager.matchPlayers();

            // 顯示遊戲歷史
            manager.displayGameHistory();
        }
    }


}
