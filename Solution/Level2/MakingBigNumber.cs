﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.Level2
{
    //문제 설명
    //어떤 숫자에서 k개의 수를 제거했을 때 얻을 수 있는 가장 큰 숫자를 구하려 합니다.
    //예를 들어, 숫자 1924에서 수 두 개를 제거하면[19, 12, 14, 92, 94, 24] 를 만들 수 있습니다.이 중 가장 큰 숫자는 94 입니다.
    //문자열 형식으로 숫자 number와 제거할 수의 개수 k가 solution 함수의 매개변수로 주어집니다. number에서 k 개의 수를 제거했을 때 만들 수 있는 수 중 가장 큰 숫자를 문자열 형태로 return 하도록 solution 함수를 완성하세요.

    //제한 조건
    //number는 1자리 이상, 1,000,000자리 이하인 숫자입니다.
    //k는 1 이상 number의 자릿수 미만인 자연수입니다.
    
    //입출력 예
    //number        k	return
    //"1924"        2	"94"
    //"1231234"     3	"3234"
    //"4177 2528 41"  4	"775841"

    public class MakingBigNumber
    {
        public string solution(string number, int k)
        {
            int index = 0;
            List<char> numberList = new List<char>(number);

            while (numberList.Count > number.Length - k)
            {
                if (numberList[index % numberList.Count] < numberList[(index + 1) % numberList.Count])
                    numberList.RemoveAt(index % numberList.Count);
                else
                    index += 1;
            }


            //다음 로직 구현 .. 내 앞에 큰놈이 있으면 안되,, 앞에서 부터

            return new string(numberList.ToArray());
        }
    }
}
