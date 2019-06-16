int[,] cardlist = new int[4, 13];
int[,] cardUsed = new int[4, 13];

// 섞인 카드 덱
int[,] resultCardlist = new int[4, 13];

int[] cardtemp = new int[4 * 13];

// 카드 초기화
for (int cardset = 0; cardset < 4; ++cardset)
{
    for (int cardindex = 0; cardindex < 13; ++cardindex)
    {
        cardlist[cardset, cardindex] = (cardset + 1) * 100 + (cardindex + 1);
        cardUsed[cardset, cardindex] = 0;

        // 카드 인덱스를 저장.
        cardtemp[cardset * 13 + cardindex] = cardset * 13 + cardindex;
    }
}

// 카드 섞기
int value = 0;
int temp = 0;
int randomlength = cardtemp.Length;
Random rand = new Random();

int setIndex = 0, cardIndex = 0;

for (int cardset = 0; cardset < 4 * 13; ++cardset)
{
    value = rand.Next(randomlength);

    setIndex = cardtemp[value] / 13;
    cardIndex = cardtemp[value] % 13;
    // 카드 사용 표시
    cardUsed[setIndex, cardIndex] = 1;

    // 카드 결과 저장
    resultCardlist[cardset / 13, cardset % 13] = cardlist[setIndex, cardIndex];

    // 뽑아진 카드인덱스를 배열 가장끝으로 옮긴다.
    temp = cardtemp[randomlength - 1];
    cardtemp[randomlength - 1] = cardtemp[value];
    cardtemp[value] = temp;

    // 다음 랜덤으로 뽑을 숫자를 하나 줄여준다.
    --randomlength;
}
