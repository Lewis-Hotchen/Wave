using System;
using System.Collections.Generic;
using System.Threading;

namespace Wave {
    class Program {
        static void Main(string[] args) {
            char letter = '/';
            Random rn = new Random();
            
            int waveSize = 60;
            int time = 4;
            int currentCount = 0;
            List<Stack> wave = new List<Stack>();
            for (int index = 0; index < waveSize; index++) {
                switch (rn.Next(4)) {
                    case 0:
                        letter = '3';
                            break;
                    case 1:
                        letter = '0';
                        break;
                    case 2:
                        letter = 'u';
                        break;
                    case 3:
                        letter = 'p';
                        break;
                    case 4:
                        letter = '/';
                            break;
                }
                wave.Add(new Stack(letter));

                wave[index].push();
            }

            int increment = 2;

            int halfwave = waveSize / 2;
            int waveTop = waveSize / 10;
            halfwave = halfwave - waveTop;

            //calculate stacks
            for (int waveCount = 0; waveCount < halfwave; waveCount++) {
                for (int index = 0; index < waveCount; index+= increment) {
                    wave[waveCount].push();
                }
                if (waveCount == halfwave -1) {
                    for(int waveTopCount = 0;  waveTopCount < waveTop; waveTopCount++) {
                        for(int halfwaveCount = 0; halfwaveCount < halfwave; halfwaveCount+= increment) {
                            wave[halfwave + waveTopCount].push();
                        }
                        currentCount++;
                    }
                }
                currentCount++;
            }

            int decrement = halfwave;
            for(int index = halfwave + waveTop; index < waveSize; index++) {
                for(int dec = 0; dec < decrement; dec+= increment) {
                    wave[index].push();
                }
                decrement--;
            }
            while (true) {
            for (int index = 0; index < wave.Count; index++) {
                Console.WriteLine(wave[index].ToString());
                    Thread.Sleep(time);
            }
            }
        }
    }
}
