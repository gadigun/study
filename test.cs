
struct card
{
    int index;
    int used;
}

// 정돈된카드덱
card [,] cardlist = new card[4,13];

// 섞인 카드 덱
card [,] resultCardlist = new card[4,13];

// 카드 초기화
for(int cardset = 0; cardset < 4; ++cardset)
{
    for(int i = 0; i < 13; ++i)
    {
        cardlist[cardset,i].index = i;
        cardlist[cardset,i].used = 0;
    }
}

// 카드 섞기
for(int cardset = 0; cardset < 4; ++cardset)
{
    for(int i = 0; i < 13; ++i)
    {
        cardlist[cardset,i].index = i;
        cardlist[cardset,i].used = 0;

        resultCardlist[,].
    }
}
