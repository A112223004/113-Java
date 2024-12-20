public class manager {
    import models.Player;
    import models.GameRoom;

    import java.util.ArrayList;
    import java.util.HashSet;
    import java.util.LinkedList;

    public class MatchManager {
        private ArrayList<Player> players;
        private HashSet<Player> matchQueue;
        private LinkedList<GameRoom> gameHistory;
        private int nextRoomId;

        public MatchManager() {
            this.players = new ArrayList<>();
            this.matchQueue = new HashSet<>();
            this.gameHistory = new LinkedList<>();
            this.nextRoomId = 1;
        }

        public void registerPlayer(Player player) {
            players.add(player);
            System.out.println("Player registered: " + player.getName());
        }

        public void joinMatch(Player player) {
            try {
                if (matchQueue.add(player)) {
                    player.joinMatchQueue();
                } else {
                    System.out.println("Player is already in the match queue.");
                }
            } catch (Exception e) {
                System.out.println("Error: " + e.getMessage());
            }
        }

        public void leaveMatch(Player player) {
            try {
                if (matchQueue.remove(player)) {
                    player.leaveMatchQueue();
                } else {
                    System.out.println("Player is not in the match queue.");
                }
            } catch (Exception e) {
                System.out.println("Error: " + e.getMessage());
            }
        }

        public void matchPlayers() {
            if (matchQueue.size() < 2) {
                System.out.println("Not enough players to create a match.");
                return;
            }

            ArrayList<Player> matchedPlayers = new ArrayList<>(matchQueue);
            GameRoom room = new GameRoom(nextRoomId++);
            for (int i = 0; i < 2; i++) {
                try {
                    Player player = matchedPlayers.get(i);
                    room.addPlayer(player);
                    matchQueue.remove(player);
                } catch (Exception e) {
                    System.out.println("Error: " + e.getMessage());
                }
            }
            room.startGame();
            gameHistory.add(room);
        }

        public void displayGameHistory() {
            System.out.println("Game History:");
            for (GameRoom room : gameHistory) {
                System.out.println("Room " + room.roomId);
            }
        }
    }

}
