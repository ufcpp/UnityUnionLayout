# UnityUnionLayout

https://github.com/ufcpp/UnityUnionLayout/blob/main/Assets/Scripts/Union.cs#L34-L41

こんな感じの StructLayout を使って(C言語のunion的な)レイアウトを重ねた構造体を作ったとき、参照型を含んでいても正しく動くかどうかの確認用。
この手の処理、 .NET (.NET Core)で動いても IL2CPP とかスマホ実機動作で動かないときがあるので。
