using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ef.Dz1.Migrations
{
    /// <inheritdoc />
    public partial class LyricsAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Lyrics", "Name" },
                values: new object[] { "As I walk through the valley of the shadow of death\r\nI take a look at my life and realize there's nothin' left\r\n'Cause I've been blastin' and laughin' so long that\r\nEven my momma thinks that my mind is gone\r\nBut I ain't never crossed a man that didn't deserve it\r\nMe be treated like a punk, you know that's unheard of\r\nYou better watch how you talkin' and where you walkin'\r\nOr you and your homies might be lined in chalk\r\nI really hate to trip, but I gotta loc\r\nAs they croak, I see myself in the pistol smoke\r\nFool, I'm the kinda G the little homies wanna be like\r\nOn my knees in the night, sayin' prayers in the streetlight\r\nBeen spendin' most their lives\r\nLivin' in a gangsta's paradise\r\nBeen spendin' most their lives\r\nLivin' in a gangsta's paradise\r\nKeep spendin' most our lives\r\nLivin' in a gangsta's paradise\r\nKeep spendin' most our lives\r\nLivin' in a gangsta's paradise\r\nLook at the situation they got me facing\r\nI can't live a normal life, I was raised by the street\r\nSo I gotta be down with the hood team\r\nToo much television watchin', got me chasing dreams\r\nI'm a educated fool with money on my mind\r\nGot my ten in my hand and a gleam in my eye\r\nI'm a loc'd out gangsta, set trippin' banger\r\nAnd my homies is down, so don't arouse my anger\r\nFool, death ain't nothin' but a heart beat away\r\nI'm livin' life do or die, what can I say?\r\nI'm 23 now but will I live to see 24?\r\nThe way things is going I don't know\r\nTell me why are we so blind to see\r\nThat the ones we hurt are you and me?\r\nBeen spendin' most their lives\r\nLivin' in a gangsta's paradise\r\nBeen spendin' most their lives\r\nLivin' in a gangsta's paradise\r\nKeep spendin' most our lives\r\nLivin' in a gangsta's paradise\r\nKeep spendin' most our lives\r\nLivin' in a gangsta's paradise\r\nPower and the money, money and the power\r\nMinute after minute, hour after hour\r\nEverybody's runnin', but half of them ain't lookin'\r\nIt's going on in the kitchen, but I don't know what's cookin'\r\nThey say I gotta learn, but nobody's here to teach me\r\nIf they can't understand it, how can they reach me?\r\nI guess they can't, I guess they won't\r\nI guess they front, that's why I know my life is out of luck, fool\r\nBeen spendin' most their lives\r\nLivin' in a gangsta's paradise\r\nBeen spendin' most their lives\r\nLivin' in a gangsta's paradise\r\nKeep spendin' most our lives\r\nLivin' in a gangsta's paradise\r\nKeep spendin' most our lives\r\nLivin' in a gangsta's paradise\r\nTell me why are we so blind to see\r\nThat the ones we hurt are you and me?\r\nTell me why are we so blind to see\r\nThat the ones we hurt are you and me?", "Gangstas Paradise" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Lyrics", "Name" },
                values: new object[] { "Some lyrics...", "Rap" });
        }
    }
}
