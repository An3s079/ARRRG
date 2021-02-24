using System.Collections;
using System.Collections.Generic;
using UnityEngine;  
 using UnityEngine.UI;
using System.IO;
using TMPro;
using System;
using SFB;

public class ButtonController : MonoBehaviour
{
    public Image RobotSheet;
    public Texture2D defaultSprite;
    public TMP_Text TextComponent;

    Color32 c1 = new Color32(200, 198, 169, 255);
    Color32 c2 = new Color32(126, 124, 96, 255);
    Color32 c3 = new Color32(84, 82, 61, 255);
    Color32 c4 = new Color32(32, 63, 63, 255);
    Color32 c5 = new Color32(33, 95, 93, 255);
    Color32 c6 = new Color32(245, 236, 81, 255);
    Color32 c7 = new Color32(0, 0, 0, 255);
    Color32 c8 = new Color32(255, 255, 255, 255);
    Color32 c9 = new Color32(84, 83, 62, 255);//thats right, its ONE off from c3 in two of them.
    void Update()
    {
        
    }
    public void OnGenerateSpritesPressed()
    {
      Color randomColor1 = new Color(
	UnityEngine.Random.value, //Red
	UnityEngine.Random.value, //Green
	UnityEngine.Random.value, //Blue
	1 //Alpha (transparency)
    );
   Color randomColor2 = new Color(
	UnityEngine.Random.value, //Red
	UnityEngine.Random.value, //Green
	UnityEngine.Random.value, //Blue
	1 //Alpha (transparency)
    );
    Color randomColor3 = new Color(
	UnityEngine.Random.value, //Red
	UnityEngine.Random.value, //Green
	UnityEngine.Random.value, //Blue
	1 //Alpha (transparency)
    );
    Color randomColor4 = new Color(
	UnityEngine.Random.value, //Red
	UnityEngine.Random.value, //Green
	UnityEngine.Random.value, //Blue
	1 //Alpha (transparency)
    );
    Color randomColor5 = new Color(
	UnityEngine.Random.value, //Red
	UnityEngine.Random.value, //Green
	UnityEngine.Random.value, //Blue
	1 //Alpha (transparency)
    );
    Color randomColor6 = new Color(
	UnityEngine.Random.value, //Red
	UnityEngine.Random.value, //Green
	UnityEngine.Random.value, //Blue
	1 //Alpha (transparency)
    );
    Color randomColor7 = new Color(
	UnityEngine.Random.value, //Red
	UnityEngine.Random.value, //Green
	UnityEngine.Random.value, //Blue
	1 //Alpha (transparency)
    );
    Color randomColor8 = new Color(
	UnityEngine.Random.value, //Red
	UnityEngine.Random.value, //Green
	UnityEngine.Random.value, //Blue
	1 //Alpha (transparency)
    );
    Color randomColor9 = new Color(
	UnityEngine.Random.value, //Red
	UnityEngine.Random.value, //Green
	UnityEngine.Random.value, //Blue
	1 //Alpha (transparency)
    );
    var colors = defaultSprite.GetPixels();
    for(int i=0; i<colors.Length; i++)
        if(colors[i]==c1)
            colors[i]=randomColor1;
    RobotSheet.sprite.texture.SetPixels(colors);
    RobotSheet.sprite.texture.Apply();

     for(int i=0; i<colors.Length; i++)
        if(colors[i]==c2)
            colors[i]=randomColor2;
    RobotSheet.sprite.texture.SetPixels(colors);
    RobotSheet.sprite.texture.Apply();

     for(int i=0; i<colors.Length; i++)
        if(colors[i]==c3)
            colors[i]=randomColor3;
    RobotSheet.sprite.texture.SetPixels(colors);
    RobotSheet.sprite.texture.Apply();
     
     for(int i=0; i<colors.Length; i++)
        if(colors[i]==c4)
            colors[i]=randomColor4;
    RobotSheet.sprite.texture.SetPixels(colors);
    RobotSheet.sprite.texture.Apply();

     for(int i=0; i<colors.Length; i++)
        if(colors[i]==c5)
            colors[i]=randomColor5;
    RobotSheet.sprite.texture.SetPixels(colors);
    RobotSheet.sprite.texture.Apply();

     for(int i=0; i<colors.Length; i++)
        if(colors[i]==c6)
            colors[i]=randomColor6;
    RobotSheet.sprite.texture.SetPixels(colors);
    RobotSheet.sprite.texture.Apply();

     for(int i=0; i<colors.Length; i++)
        if(colors[i]==c7)
            colors[i]=randomColor7;
    RobotSheet.sprite.texture.SetPixels(colors);
    RobotSheet.sprite.texture.Apply();

     for(int i=0; i<colors.Length; i++)
        if(colors[i]==c8)
            colors[i]=randomColor8;
    RobotSheet.sprite.texture.SetPixels(colors);
    RobotSheet.sprite.texture.Apply();

     for(int i=0; i<colors.Length; i++)
        if(colors[i]==c9)
            colors[i]=randomColor8;
    RobotSheet.sprite.texture.SetPixels(colors);
    RobotSheet.sprite.texture.Apply();
    }
    public TextAsset txt;
    public TextAsset items;
    public void GenerateStats()
    {
        string[] dict = txt.text.Split("\n"[0]);
        var nameRandom = UnityEngine.Random.Range(0,466596);
        Name = dict[nameRandom];

        var ArmorRandom = UnityEngine.Random.Range(1,12);
        Armor = ArmorRandom;

        var ItemAmount = UnityEngine.Random.Range(1,7);
        Array.Clear(StartingItems, 0, StartingItems.Length);
        StartingItems2.Clear();
        StartingItems3 = string.Empty;
        for(int i = 0; i< ItemAmount; i++)
        {
        string[] itemdict = items.text.Split("\n"[0]);
        var itemsRandom = UnityEngine.Random.Range(0,671);
        StartingItems2.Add(itemdict[itemsRandom]);
        StartingItems = StartingItems2.ToArray();
        }
        StartingItems3 = string.Join("\n", StartingItems);
        Accuracy = UnityEngine.Random.value;

        AdditionalBlanksPerFloor = UnityEngine.Random.Range(-2, 2);

        AdditionalClipCapacityMultiplier = UnityEngine.Random.Range(0.1f, 3f);
        AdditionalItemCapacity = UnityEngine.Random.Range(0, 2.1f);
        AdditionalShotBounces = UnityEngine.Random.Range(0, 5.1f);
        AdditionalShotPiercing = UnityEngine.Random.Range(0, 3.1f);
        AmmoCapacityMultiplier = UnityEngine.Random.Range(0.1f, 3.1f);
        ChargeAmountMultiplier = UnityEngine.Random.Range(0.1f, 2.1f);
        Coolness = UnityEngine.Random.Range(-10.1f, 10.1f);
        Curse = UnityEngine.Random.Range(-10.1f, 13.1f);
        Damage = UnityEngine.Random.Range(0.1f, 2.1f);
        DamageToBosses = UnityEngine.Random.Range(0.1f, 2.1f);
        DodgeRollDamage = UnityEngine.Random.Range(1.1f, 10.1f);
        DodgeRollDistanceMultiplier = UnityEngine.Random.Range(-2.1f,3.1f);
        DodgeRollSpeedMultiplier = UnityEngine.Random.Range(0.1f, 3);
        EnemyProjectileSpeedMultiplier = UnityEngine.Random.Range(0.1f, 3);
        ExtremeShadowBulletChance = 0;
        GlobalPriceMultiplier = UnityEngine.Random.Range(0.1f, 2);
        Health = 0;
        KnockbackMultiplier = UnityEngine.Random.Range(-2, 3.1f);
        MoneyMultiplierFromEnemies = UnityEngine.Random.Range(0, 2.1f);
        MovementSpeed = UnityEngine.Random.Range(-14, 21.1f);
        PlayerBulletScale = UnityEngine.Random.Range(0.1f, 2.1f);
        ProjectileSpeed = UnityEngine.Random.Range(-2, 3.1f);
        RangeMultiplier = UnityEngine.Random.Range(0.01f, 5.01f);
        RateOfFire = UnityEngine.Random.Range(0.1f, 3f);
        ReloadSpeed = UnityEngine.Random.Range(0.01f, 3.02f);
        ShadowBulletChance = 0;
        TarnisherClipCapacityMultiplier = UnityEngine.Random.Range(0.1f, 3);
        ThrownGunDamage = UnityEngine.Random.Range(0,5.1f);

        loadout = 
    "base: Robot\n"+
    "name short: " + Name +
    "\nname: "+ Name +
    "\nnickname "+Name +
    "\narmor: "+ ArmorRandom +
    "\n\n<loadout>\n"+ StartingItems3 +
    "\n</loadout>\n\n"+
    "<stats>\n"+

"Accuracy: "+ Accuracy +
"\nAdditionalBlanksPerFloor: "+ AdditionalBlanksPerFloor +
"\nAdditionalClipCapacityMultiplier: "+ AdditionalClipCapacityMultiplier+
"\nAdditionalGunCapacity: "+ AdditionalGunCapacity +
"\nAdditionalItemCapacity: "+ AdditionalItemCapacity + 
"\nAdditionalShotBounces: "+ AdditionalShotBounces +
"\nAdditionalShotPiercing: "+ AdditionalShotPiercing +
"\nAmmoCapacityMultiplier: "+ AmmoCapacityMultiplier +
"\nChargeAmountMultiplier: "+ ChargeAmountMultiplier +
"\nCoolness: "+ Coolness +
"\nCurse: "+ Curse +
"\nDamage: "+ Damage +
"\nDamageToBosses: "+DamageToBosses +
"\nDodgeRollDamage: "+ DodgeRollDamage +
"\nDodgeRollDistanceMultiplier: "+ DodgeRollDistanceMultiplier +
"\nDodgeRollSpeedMultiplier: "+ DodgeRollSpeedMultiplier +
"\nEnemyProjectileSpeedMultiplier: "+ EnemyProjectileSpeedMultiplier +
"\nExtremeShadowBulletChance: "+ ExtremeShadowBulletChance+
"\nGlobalPriceMultiplier: "+ GlobalPriceMultiplier +
"\nHealth: 0"+
"\nKnockbackMultiplier: "+ KnockbackMultiplier +
"\nMoneyMultiplierFromEnemies: "+ MoneyMultiplierFromEnemies +
"\nMovementSpeed: "+ MovementSpeed +
"\nPlayerBulletScale: "+ PlayerBulletScale +
"\nProjectileSpeed: "+ ProjectileSpeed +
"\nRangeMultiplier: "+ RangeMultiplier +
"\nRateOfFire: "+ RateOfFire +
"\nReloadSpeed: "+ ReloadSpeed +
"\nShadowBulletChance: "+ ShadowBulletChance + 
"\nTarnisherClipCapacityMultiplier: "+ TarnisherClipCapacityMultiplier +
"\nThrownGunDamage: "+ ThrownGunDamage +
"\n</stats>";

        TextComponent.text = loadout;
    }

    private byte[] _textureBytes;
    public void ExportImage()
    {
        _textureBytes = RobotSheet.sprite.texture.EncodeToPNG();
        var path = StandaloneFileBrowser.SaveFilePanel("playersheet", "", "playersheet", "png");
        if (!string.IsNullOrEmpty(path)) {
            File.WriteAllBytes(path, _textureBytes);
        }
    }
    public void ExportText()
    {
        var path = StandaloneFileBrowser.SaveFilePanel("characterdata", "", "characterdata", "txt");
        if (!string.IsNullOrEmpty(path)) {
            File.WriteAllText(path, loadout);
        }
    }

    public void quit()
    {
        Application.Quit();
    }
    private string Name;

    //loadoutString

 string loadout;
 string[] StartingItems = new string[] {"downloadPrismatism"};
 List<string> StartingItems2 = new List<string>();
 string StartingItems3;
 float Armor;
float Accuracy;
float AdditionalBlanksPerFloor;
float AdditionalClipCapacityMultiplier;
float AdditionalGunCapacity;
float AdditionalItemCapacity;
float AdditionalShotBounces;
float AdditionalShotPiercing;
float AmmoCapacityMultiplier;
float ChargeAmountMultiplier;
float Coolness;
float Curse;
float Damage;
float DamageToBosses;
float DodgeRollDamage;
float DodgeRollDistanceMultiplier;
float DodgeRollSpeedMultiplier;
float EnemyProjectileSpeedMultiplier;
float ExtremeShadowBulletChance;
float GlobalPriceMultiplier;
float Health;
float KnockbackMultiplier;
float MoneyMultiplierFromEnemies;
float MovementSpeed;
float PlayerBulletScale;
float ProjectileSpeed;
float RangeMultiplier;
float RateOfFire;
float ReloadSpeed;
float ShadowBulletChance;
float TarnisherClipCapacityMultiplier;
float ThrownGunDamage;
}
