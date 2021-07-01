# BlueBack.Mouse
マウス操作
* マウスの位置、ボタン、ホイールの取得
* FixedUpdateでのダウン、アップ、連射の取得

## ライセンス
MIT License
* https://github.com/bluebackblue/Mouse/blob/main/LICENSE

## 外部依存 / 使用ライセンス等
* https://github.com/bluebackblue/UnityPlayerLoop

## 動作確認
Unity 2021.1.11f1

## UPM
### 最新
* https://github.com/bluebackblue/Mouse.git?path=unity_Mouse/Assets/UPM#0.0.7
### 開発
* https://github.com/bluebackblue/Mouse.git?path=unity_Mouse/Assets/UPM

## Unityへの追加方法
* Unity起動
* メニュー選択：「Window->Package Manager」
* ボタン選択：「左上の＋ボタン」
* リスト選択：「Add package from git URL...」
* 上記UPMのURLを追加「 https://github.com/～～/UPM#バージョン 」
### 注
Gitクライアントがインストールされている必要がある。
* https://docs.unity3d.com/ja/current/Manual/upm-git.html
* https://git-scm.com/

## 例
```
/** Update用。
*/
private BlueBack.Mouse.Mouse mouse;

/** FixedUpdate用。
*/
private BlueBack.Mouse.Mouse mouse_fixedupdate;

/** Start
*/
private void Start()
{
	//Update用。
	this.mouse = new BlueBack.Mouse.Mouse(BlueBack.Mouse.Mode.Update,new BlueBack.Mouse.Param());

	//FixedUpdate用。
	this.mouse_fixedupdate = new BlueBack.Mouse.Mouse(BlueBack.Mouse.Mode.FixedUpdate,new BlueBack.Mouse.Param());
}

/** Update
*/
private void Update()
{
	if(this.mouse.left.down == true){
		UnityEngine.Debug.Log("Update.Left.Down");
	}
}

/** FixedUpdate
*/
private void FixedUpdate()
{
	if(this.mouse_fixedupdate.left.down == true){
		UnityEngine.Debug.Log("FixedUpdate.Left.Down");
	}
}
```

