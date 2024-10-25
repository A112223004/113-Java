package edu.shu.liangg;

public class Time1 {
    private int hour;
    //時(hour)
    private int minute;
    //分(minute)
    private int second;
    //秒(second)

    //建構子(設定時、分、秒的初始值，需檢查資料是否格式正確)
    public Time1(int hour, int minute, int second) {
        this.hour = hour;
        this.minute = minute;
        this.second = second;
    }

    //方法:是需要加入get/set
    public int getHour() {return this.hour;}

    public int getMinute() {return this.minute;}

    public int getSecond() {return this.second;}

    //方法: tick (時間增加一秒)
    public void clock (int time){
        second += time;
        if (this.second >= 60){
            this.second -= 60;
            this.minute ++;
        }
        if (this.minute >= 60){
            this.minute -= 60;
            this.hour ++;
        }
        if (this.hour >= 24){
            this.hour = 0;
        }
    }

    //方法: printUniversal (以24小時制輸出完整時間 14:05:32)

    //方法: printStandard (以12小時制輸出完整時間 2:05:32 pm)
}
