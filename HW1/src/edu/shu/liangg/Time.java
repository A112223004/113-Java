package edu.shu.liangg;

public class Time1 {
    private int hour;
    private int minute;
    private int second;

    // 建構子，初始化時間，檢查格式是否正確
    public Time1(int hour, int minute, int second) {
        // 檢查小時是否介於0到23之間
        if (hour >= 0 && hour < 24) {
            this.hour = hour;
        } else {
            this.hour = 0; // 若格式錯誤則設為0
        }

        // 檢查分鐘是否介於0到59之間
        if (minute >= 0 && minute < 60) {
            this.minute = minute;
        } else {
            this.minute = 0; // 若格式錯誤則設為0
        }

        // 檢查秒數是否介於0到59之間
        if (second >= 0 && second < 60) {
            this.second = second;
        } else {
            this.second = 0; // 若格式錯誤則設為0
        }
    }

    // Getter方法
    public int getHour() {
        return this.hour;
    }

    public int getMinute() {
        return this.minute;
    }

    public int getSecond() {
        return this.second;
    }

    // tick方法，時間增加指定的秒數
    public void clock(int time) {
        this.second += time;

        // 處理秒數溢出的情況
        while (this.second >= 60) {
            this.second -= 60;
            this.minute++;
        }

        // 處理分鐘溢出的情況
        while (this.minute >= 60) {
            this.minute -= 60;
            this.hour++;
        }

        // 處理小時溢出的情況，24小時制
        if (this.hour >= 24) {
            this.hour = 0;
        }
    }

    // 輸出24小時制時間格式 "14:05:32"
    public void printUniversal() {
        System.out.printf("%02d:%02d:%02d\n", this.hour, this.minute, this.second);
    }

    // 輸出12小時制時間格式 "2:05:32 PM"
    public void printStandard() {
        int hour12 = this.hour % 12;  // 轉換為12小時制
        String period = (this.hour >= 12) ? "PM" : "AM";

        // 12小時制中的0應該顯示為12
        if (hour12 == 0) {
            hour12 = 12;
        }

        System.out.printf("%d:%02d:%02d %s\n", hour12, this.minute, this.second, period);
    }

    // 測試主程式
    public static void main(String[] args) {
        Time1 time = new Time1(14, 5, 32); // 創建時間物件

        // 顯示時間
        time.printUniversal();  // 顯示 24 小時制時間
        time.printStandard();   // 顯示 12 小時制時間

        // 時間增加 5000 秒
        time.clock(5000);

        // 顯示增加後的時間
        time.printUniversal();
        time.printStandard();
    }
}
