   M S B A M L   `   `   `  ????K  GWPFAuthorization, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:WPFAuthorization.View.WindowsWPFAuthorization.View.Windows  5   	   G(clr-namespace:WPFAuthorization.ViewModelWPFAuthorization.ViewModel  5   
   !    WPFAuthorization.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   =local+clr-namespace:WPFAuthorization.View.Windows     5   	   >	ViewModel(clr-namespace:WPFAuthorization.ViewModel     5   
     ? Title$  
MainWindow??5	   	   $	??570??6   $	??550??6)    ? DataContext 5
      4   .WPFAuthorization.ViewModel.MainWindowViewModel  5   
   .??5      ?  ? RowDefinitions 5   
   ?? 5      ?? 5      ?? 5      .+?5   
   ? 
???????.+?5      ?? $??Авторизация??6   $??Center=?6+   $??Center=?6H   $??30(?6c   5      ? 5   
   $??1??6    5      ?? 5      ?? 5       ? ColumnDefinitions 5      ?? 5      $	??70* ?6#   ?? 5      $	??85* ?6#   .+?5      ?? $??Логин:??6   $??20(?6&   $??40,0,0,0q?64   $
??Left=?6F   $??Center=?6a   ?? 5       -   5         ??Name$ loginBox??5       $??1??6(   $??20(?68   $??30q?6F   ??6R   ?? *UserLoging.Login+?? 5!      $??Пароль:??6   $	?? 20(?6'   $??2??66   $??40,0,0,0q?6C   $
??Left=?6U   $??Center=?6p   G? 5"      -   5         G?Name$ passwordBox??5"      $??1??6/   $??2??6?   $??20(?6L   $??30q?6Z   6f   5#      ? 5$   
   $??2??6    5%      ?? 5&      ?? 5'      .+?5)      ?? -   5         ??Name$ enterDataButton??5)   o   $??0??6   $??
Войти??6"   $??200,20,200,20q?62   
???????$??20(?6a   ??6?   ?? *ValidationCommand+?? 5*      -   5        $ exitDataButton??5*   o   $??1??6   $??
Выйти??6"   $??200,20,200,20q?62   
???????$??20(?6a   ??6?   ?? *ExitCommand+5+      5,      5-      