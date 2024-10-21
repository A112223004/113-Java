package edu.shu.main;
import edu.shu.liang.CashCard;
import edu.shu.liangg.*;

import java.util.Scanner;

public class Time1Test {
    public static void main(String[] args){
        //Time1 time = new ...
        Time1[] clocks ={
                new Time1(14, 05, 32),
                new Time1(11, 30, 22),
                new Time1(9, 10, 15),

        };

        //呼叫printUniversal()

        //呼叫printStandard()

        //使用者輸入時間過了幾秒，用迴圈呼叫tick
        Scanner input = new Scanner(System.in);
        for(Time1 time : clocks)
        {
            System.out.printf(time.getHour(), time.getMinute(), time.getSecond());

        }

        //呼叫printUniversal()

        //呼叫printStandard()
    }
}
