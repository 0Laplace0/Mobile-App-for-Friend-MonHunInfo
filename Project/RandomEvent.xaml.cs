using System;
using System.Collections.Generic;
using Microsoft.Maui.Controls;

namespace Project;

public partial class RandomEvent : ContentPage
{
	public RandomEvent()
	{
		InitializeComponent();
        SetRandomImage();
    }

    private List<string> monsterImages = new List<string>
        {
            "bariothicon",
            "brachydiosicon",
            "deviljhoicon",
            "diablosicon",
            "fatalisicon",
            "glavenusicon",
            "kushalaicon",
            "lagiacrusicon",
            "mizutsuneicon",
            "nargacugaicon",
            "nergiganteicon",
            "rajangicon",
            "rathalosicon",
            "rathianicon",
            "tigrexicon",
            "velkhanaicon",
            "zinogreicon"
        };

    private List<string> weaponImages = new List<string>
        {
            "bwicon",
            "cbicon",
            "dbicon",
            "glicon",
            "gsicon",
            "hgicon",
            "hhicon",
            "hmicon",
            "igicon",
            "laicon",
            "lgicon",
            "lsicon",
            "saicon",
            "ssicon"
        };

    private void RandomImage_Click(object sender, EventArgs e)
    {
        SetRandomImage();
    }

    private void SetRandomImage()
    {
        Random random = new Random();
        int monsterIndex = random.Next(monsterImages.Count);
        string selectedMonster = monsterImages[monsterIndex];

        // สุ่มเลือกรูปจากหมวดอาวุธ
        int weaponIndex = random.Next(weaponImages.Count);
        string selectedWeapon = weaponImages[weaponIndex];

        RandomImageMonster.Source = ImageSource.FromFile(selectedMonster);
        RandomImageWeapons.Source = ImageSource.FromFile(selectedWeapon);
    }
}