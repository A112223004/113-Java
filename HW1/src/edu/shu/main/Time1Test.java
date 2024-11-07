package edu.shu.main;

import edu.shu.liangg.*;
import java.util.Scanner;

public class Time1Test {
    public static void main(String[] args) {
        // 創建 Time1 物件陣列並初始化時間
        Time1[] clocks = {
                new Time1(14, 05, 32),  // 14:05:32
                new Time1(11, 30, 22),  // 11:30:22
                new Time1(9, 10, 15),   // 09:10:15
        };

        // 呼叫 printUniversal 和 printStandard 方法來顯示時間
        for (Time1 time : clocks) {
            System.out.print("Universal Time: ");
            time.printUniversal();  // 輸出 24 小時制時間

            System.out.print("Standard Time: ");
            time.printStandard();  // 輸出 12 小時制時間
        }

        // 使用者輸入時間過了幾秒，並使用迴圈呼叫 tick
        Scanner input = new Scanner(System.in);
        System.out.print("請輸入您想增加的秒數：");
        int secondsToAdd = input.nextInt();  // 讀取使用者輸入的秒數

        for (Time1 time : clocks) {
            time.clock(secondsToAdd);  // 增加指定的秒數
            System.out.print("增加後的 Universal Time: ");
            time.printUniversal();  // 輸出 24 小時制時間

            System.out.print("增加後的 Standard Time: ");
            time.printStandard();  // 輸出 12 小時制時間
        }
    }
}
