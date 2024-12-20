public class models {
    import interfaces.Matchable;

    public class Player implements Matchable {
        private int id;
        private String name;
        private int score;
        private boolean inMatchQueue;

        public Player(int id, String name, int score) {
            this.id = id;
            this.name = name;
            this.score = score;
            this.inMatchQueue = false;
        }

        public int getId() {
            return id;
        }

        public String getName() {
            return name;
        }

        public int getScore() {
            return score;
        }

        @Override
        public void joinMatchQueue() throws Exception {
            if (inMatchQueue) {
                throw new Exception("Player is already in the match queue.");
            }
            inMatchQueue = true;
            System.out.println(name + " joined the match queue.");
        }

        @Override
        public void leaveMatchQueue() throws Exception {
            if (!inMatchQueue) {
                throw new Exception("Player is not in the match queue.");
            }
            inMatchQueue = false;
            System.out.println(name + " left the match queue.");
        }
    }

}

