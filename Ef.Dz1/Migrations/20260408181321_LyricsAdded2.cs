using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ef.Dz1.Migrations
{
    /// <inheritdoc />
    public partial class LyricsAdded2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PlayCount", "Rating" },
                values: new object[] { 2023144212, 4.8m });

            migrationBuilder.UpdateData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Lyrics", "Name", "PlayCount", "Rating" },
                values: new object[] { "Damn, Callan (Damn, Callan)\r\nOne bad bitch and she do what I say so (One, gang)\r\nTwo big .40s and a big ass Draco (Two, boom, boom)\r\nThree more millions when you ask how my day go (Three)\r\nPoured up a four, now that blueberry Faygo\r\nOne false move, and we straight to shooting shit\r\nTwo small bands just to take you out real quick (Bands)\r\nThree more hoes, pull up, I'm fucking shit (Three more, gang)\r\nThat's how it goes, big bands, I'm thumbin' shit (That's how it goes)\r\nAyy, one bad bitch and she do what I say so (Yeah, gang)\r\nTwo big .40s and a big ass Draco (Two)\r\nThree more millions when you ask how my day go\r\nPoured up a four, now that blueberry Faygo\r\nOne false move, and we straight to shooting shit\r\nTwo small bands just to take you out real quick (Bands)\r\nThree more hoes, pull up, I'm fucking shit (Three, yeah)\r\nThat's how it goes, big bands, I'm thumbin' shit (Gang)\r\nI'm with my niggas, yeah, we some rockstars\r\nAnd I'm with my nigga, yeah, KK Wokhardt (KK Wokhardt)\r\nThis not my dick, lil' bitch, my Glock hard (Lil' bitch)\r\nStraight to the cash (Cash), I'm a trapstar\r\nStraight to the bag (Bag), I'm that nigga, huh (Uh)\r\nGot me some gas, rollin' up some\r\nPfft, pfft, cash, yeah, I got me some\r\nI ain't fucked her yesterday (Yeah)\r\nI'ma fuck some\r\nOne bad bitch and she do what I say so (One, gang)\r\nTwo big .40s and a big ass Draco (Two, boom, boom)\r\nThree more millions when you ask how my day go (Three)\r\nPoured up a four, now that blueberry Faygo\r\nOne false move, and we straight to shooting shit\r\nTwo small bands just to take you out real quick (Bands)\r\nThree more hoes, pull up, I'm fucking shit (Three more, gang)\r\nThat's how it goes, big bands, I'm thumbin' shit (That's how it goes)\r\n3-0, clip in my Nina (Ooh-ooh)\r\nOn my toes, Gucci, Valentina (Yeah, bitch)\r\nShe on go, your bitch fuck the team, uh (Lil' bitch)\r\n'Cause you know your bitch want a winner (Winner)\r\nI just went back to my city (To my city)\r\nAnd you know they all fuckin' with me (Yeah, yes)\r\nBut it ain't safe, hoes with me (Hoes)\r\nI'ma chase bands 'til they end me\r\nOne bad bitch and she do what I say so (One, gang)\r\nTwo big .40s and a big ass Draco (Two, boom, boom)\r\nThree more millions when you ask how my day go (Three)\r\nPoured up a four, now that blueberry Faygo\r\nOne false move, and we straight to shooting shit\r\nTwo small bands just to take you out real quick (Bands)\r\nThree more hoes, pull up, I'm fucking shit (Three more, gang)\r\nThat's how it goes, big bands, I'm thumbin' shit (That's how it goes)\r\nAyy, one bad bitch, and she do what I say so (Yeah, gang)\r\nTwo big .40s and a big ass Draco (Two)\r\nThree more millions when you ask how my day go\r\nPoured up a four, now that blueberry Faygo\r\nOne false move, and we straight to shooting shit\r\nTwo small bands just to take you out real quick (Bands)\r\nThree more hoes, pull up, I'm fucking shit (Three, yeah)\r\nThat's how it goes, big bands, I'm thumbin' shit (Gang)", "Blueberry Faygo", 1697604708, 4.9m });

            migrationBuilder.InsertData(
                table: "Tracks",
                columns: new[] { "Id", "AlbumId", "Duration", "Lyrics", "Name", "PlayCount", "Rating" },
                values: new object[] { 3, 2, 3.21m, null, "Sneako", 102, 3.8m });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PlayCount", "Rating" },
                values: new object[] { 1000, 4.5m });

            migrationBuilder.UpdateData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Lyrics", "Name", "PlayCount", "Rating" },
                values: new object[] { null, "Song", 500, 3.8m });
        }
    }
}
