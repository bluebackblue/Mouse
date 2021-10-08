

/**
 * Copyright (c) blueback
 * Released under the MIT License
 * @brief 設定。
*/


/** Editor
*/
#if(UNITY_EDITOR)
namespace Editor
{
	/** UpmVersionManagerSetting
	*/
	[UnityEditor.InitializeOnLoad]
	public static class UpmVersionManagerSetting
	{
		/** UpmVersionManagerSetting
		*/
		static UpmVersionManagerSetting()
		{
			//Object_RootUssUxml
			BlueBack.UpmVersionManager.Editor.Object_RootUssUxml.Save(false);

			BlueBack.UpmVersionManager.Editor.Object_Setting.s_param = new BlueBack.UpmVersionManager.Editor.Object_Setting.Param();
			BlueBack.UpmVersionManager.Editor.Object_Setting.Param t_param = BlueBack.UpmVersionManager.Editor.Object_Setting.s_param;
			{
				//author_name
				t_param.author_name = "BlueBack";

				//git_url
				t_param.git_url = "https://github.com/";

				//git_author
				t_param.git_author = "bluebackblue";

				//git_path
				t_param.git_path = "unity_Mouse/Assets/UPM";

				//package_name
				t_param.package_name = "Mouse";

				//packagejson_unity
				t_param.packagejson_unity = "2020.1";

				//packagejson_discription
				t_param.packagejson_discription = "マウス操作";

				//packagejson_keyword
				t_param.packagejson_keyword = new string[]{
					"input","mouse",
				};

				//packagejson_dependencies
				t_param.packagejson_dependencies = new System.Collections.Generic.Dictionary<string,string>(){
					//{"xxxxx.xxxxx","https://github.com/xxxxx/xxxxx"},
				};

				//root_readmemd_path
				t_param.root_readmemd_path = "../../README.md";

				//asmdef_runtime
				t_param.asmdef_runtime = new BlueBack.UpmVersionManager.Editor.Object_Setting.Param.AsmdefItem{
					reference_list = new BlueBack.UpmVersionManager.Editor.Object_Setting.Param.AsmdefReferenceItem[]{
						new BlueBack.UpmVersionManager.Editor.Object_Setting.Param.AsmdefReferenceItem(){
							package_name = "BlueBack.UnityPlayerLoop",
							url = "https://github.com/bluebackblue/UnityPlayerLoop",
						},
					},
					versiondefine_list = new BlueBack.UpmVersionManager.Editor.Object_Setting.Param.AsmdefVersionDefineItem[]{
					},
				};

				//asmdef_editor
				t_param.asmdef_editor = new BlueBack.UpmVersionManager.Editor.Object_Setting.Param.AsmdefItem{
					reference_list = new BlueBack.UpmVersionManager.Editor.Object_Setting.Param.AsmdefReferenceItem[]{
						new BlueBack.UpmVersionManager.Editor.Object_Setting.Param.AsmdefReferenceItem(){
							package_name = "BlueBack.Mouse",
							url = "https://github.com/bluebackblue/Mouse",
						},
					},
					versiondefine_list = new BlueBack.UpmVersionManager.Editor.Object_Setting.Param.AsmdefVersionDefineItem[]{
					},
				};

				//asmdef_sample
				t_param.asmdef_sample = new BlueBack.UpmVersionManager.Editor.Object_Setting.Param.AsmdefItem{
					reference_list = new BlueBack.UpmVersionManager.Editor.Object_Setting.Param.AsmdefReferenceItem[]{
						new BlueBack.UpmVersionManager.Editor.Object_Setting.Param.AsmdefReferenceItem(){
							package_name = "BlueBack.Mouse",
							url = "https://github.com/bluebackblue/Mouse",
						},
						new BlueBack.UpmVersionManager.Editor.Object_Setting.Param.AsmdefReferenceItem(){
							package_name = "BlueBack.Mouse.Editor",
							url = "https://github.com/bluebackblue/Mouse",
						},
					},
					versiondefine_list = new BlueBack.UpmVersionManager.Editor.Object_Setting.Param.AsmdefVersionDefineItem[]{
					},
				};

				//changelog
				t_param.changelog = new string[]{
					"# Changelog",
					"",

					"## [0.0.1] - 2021-04-09",
					"### Changes",
					"- Init",
					"",
				};

				//readme_md
				t_param.object_root_readme_md = new BlueBack.UpmVersionManager.Editor.Object_Setting.Creator_Type[]{

					//概要。
					(in BlueBack.UpmVersionManager.Editor.Object_Setting.Creator_Argument a_argument) => {
						return new string[]{
							"# " + t_param.author_name + "." + t_param.package_name,
							"マウス操作",
							"* マウスの位置、ボタン、ホイールの取得",
							"* FixedUpdateでのダウン、アップ、連射の取得",
						};
					},

					//ライセンス。
					(in BlueBack.UpmVersionManager.Editor.Object_Setting.Creator_Argument a_argument) => {
						return new string[]{
							"## ライセンス",
							"MIT License",
							"* " + t_param.git_url + t_param.git_author + "/" + t_param.package_name + "/blob/main/LICENSE",
						};
					},

					//依存。
					(in BlueBack.UpmVersionManager.Editor.Object_Setting.Creator_Argument a_argument) => {
						System.Collections.Generic.List<string> t_list = new System.Collections.Generic.List<string>();
						t_list.Add("## 依存 / 使用ライセンス等");
						t_list.AddRange(BlueBack.UpmVersionManager.Editor.Object_Setting.Create_RootReadMd_Asmdef_Dependence(a_argument));
						return t_list.ToArray();
					},

					//動作確認。
					(in BlueBack.UpmVersionManager.Editor.Object_Setting.Creator_Argument a_argument) => {
						return new string[]{
							"## 動作確認",
							"Unity " + UnityEngine.Application.unityVersion,
						};
					},

					//UPM。
					(in BlueBack.UpmVersionManager.Editor.Object_Setting.Creator_Argument a_argument) => {
						return new string[]{
							"## UPM",
							"### 最新",
							"* " + t_param.git_url + t_param.git_author + "/" + t_param.package_name + ".git?path=" + t_param.git_path + "#" + a_argument.version,
							"### 開発",
							"* " + t_param.git_url + t_param.git_author + "/" + t_param.package_name + ".git?path=" + t_param.git_path,
						};
					},

					//インストール。 
					(in BlueBack.UpmVersionManager.Editor.Object_Setting.Creator_Argument a_argument) => {
						return new string[]{
							"## Unityへの追加方法",
							"* Unity起動",
							"* メニュー選択：「Window->Package Manager」",
							"* ボタン選択：「左上の＋ボタン」",
							"* リスト選択：「Add package from git URL...」",
							"* 上記UPMのURLを追加「 https://github.com/～～/UPM#バージョン 」",
							"### 注",
							"Gitクライアントがインストールされている必要がある。",
							"* https://docs.unity3d.com/ja/current/Manual/upm-git.html",
							"* https://git-scm.com/",
						};
					},

					//例。
					(in BlueBack.UpmVersionManager.Editor.Object_Setting.Creator_Argument a_argument) => {
						return new string[]{
							"## 例",

							"```",
							"/** Update用。",
							"*/",
							"private BlueBack.Mouse.Mouse mouse;",
							"",
							"/** FixedUpdate用。",
							"*/",
							"private BlueBack.Mouse.Mouse mouse_fixedupdate;",
							"",
							"/** Start",
							"*/",
							"private void Start()",
							"{",
							"	//Update用。",
							"	this.mouse = new BlueBack.Mouse.Mouse(BlueBack.Mouse.Mode.Update,BlueBack.Mouse.InitParam.CreateDefault());",
							"",
							"	//FixedUpdate用。",
							"	this.mouse_fixedupdate = new BlueBack.Mouse.Mouse(BlueBack.Mouse.Mode.FixedUpdate,BlueBack.Mouse.InitParam.CreateDefault());",
							"}",
							"",
							"/** Update",
							"*/",
							"private void Update()",
							"{",
							"	if(this.mouse.left.down == true){",
							"		UnityEngine.Debug.Log(\"Update.Left.Down\");",
							"	}",
							"}",
							"",
							"/** FixedUpdate",
							"*/",
							"private void FixedUpdate()",
							"{",
							"	if(this.mouse_fixedupdate.left.down == true){",
							"		UnityEngine.Debug.Log(\"FixedUpdate.Left.Down\");",
							"	}",
							"}",

							"```",
						};
					},
				};
			}
		}
	}
}
#endif

