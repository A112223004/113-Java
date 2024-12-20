public interface interfaces {

        // Matchable.java
        public interface Matchable {
            void joinMatchQueue() throws Exception;
            void leaveMatchQueue() throws Exception;
        }

        // Playable.java
        public interface Playable {
            void addPlayer(models player) throws Exception;
            void startGame();
            void endGame();
        }

    
}
