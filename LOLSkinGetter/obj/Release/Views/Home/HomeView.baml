   M S B A M L   `   `   `  ���� H  DLOLSkinGetter, Version=2.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:LOLSkinGetter.ControllersLOLSkinGetter.Controllers  C&clr-namespace:LOLSkinGetter.Views.HomeLOLSkinGetter.Views.Home  -clr-namespace:LOLSkinGetterLOLSkinGetter  '    !LOLSkinGetter.Views.Home.HomeView   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SAy.Framework.WPF, Version=6.0.0.0, Culture=neutral, PublicKeyToken=bb01a39f4f86242fR NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     *controlhttp://www.ayjs.net/controls  &ayihttp://www.ayjs.net/behavior  c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  h dMicrosoft.Expression.Interactions, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bei9http://schemas.microsoft.com/expression/2010/interactions  8
controller'clr-namespace:LOLSkinGetter.Controllers  2local&clr-namespace:LOLSkinGetter.Views.Home  $ccclr-namespace:LOLSkinGetter    N� 
FontFamily$  微软雅黑)� N� Title$ HomeView�� � DataContext .   (LOLSkinGetter.Controllers.HomeController  .��� .+�.  (Ay.Framework.WPF.Controls.AyScrollViewer  -     Name$ 	svToolBox��   webbrowserScrollViewer#��[   J� SnapsToDevicePixels .  � UseLayoutRounding . .��� .+��� .+��� $��42��
����������#CACACA$��0,0,0,1q�._��� $A��;/LOLSkinGetter;component/Contents/Images/Body_Bd/Header.png��$��Center=�$��Center=�$
��None=��� $C��=pack://siteoforigin:,,,/Contents/Images/Body_Bd/bg-header.jpg��$	��840��$��Center=�$	��Top=�$��UniformToFill=��� $B��<pack://siteoforigin:,,,/Contents/Images/Body_Bd/bg-step1.jpg��$	��543��$��Center=�$	��Top=�$��UniformToFill=��� $B��<pack://siteoforigin:,,,/Contents/Images/Body_Bd/bg-step2.jpg��$	��607��$��Center=�$	��Top=�$��UniformToFill=��� $B��<pack://siteoforigin:,,,/Contents/Images/Body_Bd/bg-step3.jpg��$	��870��$��Center=�$	��Top=�$��UniformToFill=��� $B��<pack://siteoforigin:,,,/Contents/Images/Body_Bd/bg-step4.jpg��$
��1692��$��Center=�$	��Top=�$��UniformToFill=��� $B��<pack://siteoforigin:,,,/Contents/Images/Body_Bd/bg-step5.jpg��$	��979��$��Center=�$	��Top=�$��UniformToFill=��� $B��<pack://siteoforigin:,,,/Contents/Images/Body_Bd/bg-step6.jpg��$
��1229��$��Center=�$	��Top=�$��UniformToFill=��� $	��220��$	��116��$��	72,62,0,0q�$@��:/LOLSkinGetter;component/Contents/Images/Body_Bd/spr_9.png��$
��Left=�$	��Top=�$
��None=�� $��0 42 0 0q�.+��� $��Center=�$	��Top=� �� Orientation$ 
Horizontal=�$��	0,605,0,0q�.+��� $��42��$��28(����#FFFFFF 珍稀守卫限时销售，赠�� $��42��$��28(�$
��Bold"����#ffd74e星光水晶�� $��Center=�$	��Top=�$ 
Horizontal=�$��	0,696,0,0q�.+�-  'Ay.Framework.WPF.Controls.AyImageButton  $	��194��$��69��   Icon$A ;/LOLSkinGetter;component/Contents/Images/Body_Bd/nav1_1.png��   	HoverIcon$A ;/LOLSkinGetter;component/Contents/Images/Body_Bd/nav1_2.png��	   PressedIcon$A	 ;/LOLSkinGetter;component/Contents/Images/Body_Bd/nav1_2.png��
   
RenderMode$
 Manner=�  $	��247��$��69��$A ;/LOLSkinGetter;component/Contents/Images/Body_Bd/nav2_1.png��$A ;/LOLSkinGetter;component/Contents/Images/Body_Bd/nav2_2.png��$A	 ;/LOLSkinGetter;component/Contents/Images/Body_Bd/nav2_2.png��$
 Manner=�  $	��219��$��69��$A ;/LOLSkinGetter;component/Contents/Images/Body_Bd/nav3_1.png��$A ;/LOLSkinGetter;component/Contents/Images/Body_Bd/nav3_2.png��$A	 ;/LOLSkinGetter;component/Contents/Images/Body_Bd/nav3_2.png��$
 Manner=�  $	��240��$��69��$A ;/LOLSkinGetter;component/Contents/Images/Body_Bd/nav4_1.png��$A ;/LOLSkinGetter;component/Contents/Images/Body_Bd/nav4_2.png��$A	 ;/LOLSkinGetter;component/Contents/Images/Body_Bd/nav4_2.png��$
 Manner=��� $ 
Horizontal=�$��Center=�$	��Top=�$��	0,770,0,0q� J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect     
BlurRadius$ 3Q�   ShadowDepth$ 1Q�   Color$
 #333��.+��� $��14(�
���������`�  �� StringFormat$A ;欢迎您，亲爱的 {0} 您当前绑定的大区是：{1}��.1���  �� Path$ Model.Account��� $ Model.GameArea��� $
��Left=�$��Center=�$��1,0,0,0q�$��14(��� -   $��22?�  HyperlinkYellow2#���  .�更换大区�� $��14(�$��0q�$	��2,0q�
�������.��|�� $
��Left=�$��Center=�$��1,0,0,0q�$��14(��� -   $��22?�#���  .�注销�� $ 
Horizontal=�$��Center=�$	��Top=�$	��960��$��
0,1182,0,0q�.+�  $	��146��$��52��$
 
AllOpacity=�$@ :/LOLSkinGetter;component/Contents/Images/Body_Bd/spr_6.png��.���� $ 
Horizontal=�.+��� $
��Bold"�$��14(�$��Center=����#FFFFFF充值�� $��22(�$
��Bold"�$��Center=�$	��4,0q����#ffff8550�� $��14(�$
��Bold"�$��Center=����#FFFFFF颗  $	��146��$��52��$��13,0,0,0q�$
 
AllOpacity=�$@ :/LOLSkinGetter;component/Contents/Images/Body_Bd/spr_6.png��.���� $ 
Horizontal=�.+��� $
��Bold"�$��14(�$��Center=����#FFFFFF充值�� $��22(�$
��Bold"�$��Center=�$	��4,0q����#ffff85100�� $��14(�$
��Bold"�$��Center=����#FFFFFF颗  $	��146��$��52��$��13,0,0,0q�$
 
AllOpacity=�$@ :/LOLSkinGetter;component/Contents/Images/Body_Bd/spr_6.png��.���� $ 
Horizontal=�.+��� $
��Bold"�$��14(�$��Center=����#FFFFFF充值�� $��22(�$
��Bold"�$��Center=�$	��4,0q����#ffff85500�� $��14(�$
��Bold"�$��Center=����#FFFFFF颗�� $ 
Horizontal=�$��Center=�$	��Top=�$	��960��$��
0,1240,0,0q�.+��� $��62,4,0,0q�
������ $��Center=�$��Center=�$��14(�
������� �� 
CaretBrush �#FFFFFF �� 	MaxLength$ 5��$��50��$��0q�$	��188��$��20����Z�   $	��146��$��52��$��68,0,0,0q�$
 
AllOpacity=�$@ :/LOLSkinGetter;component/Contents/Images/Body_Bd/spr_7.png��.���� $
��Bold"�$��16(�$��Center=�$��Center=����#FFFFFF确认充值  $	��146��$��52��$��58,0,0,0q�$
 
AllOpacity=�$@ :/LOLSkinGetter;component/Contents/Images/Body_Bd/spr_6.png��.���� $
��Bold"�$��16(�$��Center=�$��Center=����#FFFFFF如何购买?  $	��228��$��52��$��	20,-2,0,0q�$
 
AllOpacity=�$@ :/LOLSkinGetter;component/Contents/Images/Body_Bd/spr_8.png��.���� $
��Bold"�$��16(�$��Center=�$��Center=����#FFFFFF 已使用头像，领取钻石�� $ 
Horizontal=�$��Center=�$	��Top=�$	��960��$��
0,1300,0,0q�.+��� $��14(�$��	106,0,0,0q�$
��Left=�$	��Top=����#FFFFFF$��请输入50的倍数���� $��14(�$��	520,0,0,0q�$
��Left=�$	��Top=����#FFFFFF$)��#单个QQ号仅能领取一次钻石���� $ 
Horizontal=�$��Center=�$	��Top=�$	��960��$��
0,1540,0,0q�.+��� $��16(�$��	212,0,0,0q�$
��Left=�$	��Top=����#FFFFFF$��当前拥有���� $��16(�$��2,0,0,0q�$
��Left=�$	��Top=����#FFFFFF$
��Bold"�$��钻石���� $��16(�$��0,0,0,0q�$��68�� �� TextAlignment$ Center=�$
��Left=�$	��Top=����#FFFFFF���� *
Model.Zuan+�� $��16(�$��4,0,0,0q�$
��Left=�$	��Top=����#FFFFFF$	��颗���� -    ��Name$ tbRefreshZuan��$��16(�$��4,0,0,0q�$	��120��$
��Left=�$ Center=�$	��Top=� � Cursor$
 Hand�����#FFFFFF$��点击刷新���� $��16(�$��4,0,0,0q�$
��Left=�$	��Top=����#FFFFFF$9��3（如果购买钻石未到账，请刷新页面）���� $ 
Horizontal=�$��Center=�$	��Top=�$	��960��$��20,1840,0,0q�.+��� $��	100,4,0,0q�
������ $��Center=�$��Center=�$��14(�
������� �#FFFFFF$ 3��$��1��$��0q�$	��168��$��20����Z�   $	��138��$��52��$��36,6,0,0q�$
 
AllOpacity=�$A ;/LOLSkinGetter;component/Contents/Images/Body_Bd/spr_10.png���� $��	146,4,0,0q�
������ $��Center=�$��Center=�$��14(�
������� �#FFFFFF$ 3��$��1��$��0q�$	��188��$��20����Z�   $	��138��$��52��$��24,6,0,0q�$
 
AllOpacity=�$A ;/LOLSkinGetter;component/Contents/Images/Body_Bd/spr_10.png���� $ 
Horizontal=�$��Center=�$	��Top=�$	��960��$��
0,2148,0,0q�.+��� $��18(�$��	198,0,0,0q�$
��Left=�$	��Top=����#FFFFFF$(��"您当前拥有 普通星光水晶���� $��18(�$��6,0,0,0q�$��64��$ Center=�$
��Left=�$	��Top=����#FFFFFF���� *Model.Putong+�� $��18(�$��2,0,0,0q�$
��Left=�$	��Top=����#FFFFFF$ ��个 ， 璀璨星光水晶���� $��18(�$��2,0,0,0q�$��66��$ Center=�$
��Left=�$	��Top=����#FFFFFF���� *Model.CuiCan+�� $��18(�$��4,0,0,0q�$
��Left=�$	��Top=����#FFFFFF$	��个���� $ 
Horizontal=�$��Center=�$	��Top=�$	��960��$��
0,2386,0,0q�.+�  $	��146��$��52��$��80,0,0,0q�$
 
AllOpacity=�$@ :/LOLSkinGetter;component/Contents/Images/Body_Bd/spr_7.png��.���� $ 
Horizontal=�   $ 3Q�$ 0Q�$ #C24F48��.+��� $
��Bold"�$��14(�$��Center=����#FFFFFF使用�� $��30(�$
��Bold"�$��Center=�$	��4,0q����#ffd74e1�� $��14(�$
��Bold"�$��Center=����#FFFFFF个  -     Name$ 
btnUseTen5��$	��182��$��50��$��7,-2,0,0q�$
 
AllOpacity=�$A ;/LOLSkinGetter;component/Contents/Images/Body_Bd/spr_11.png��.���� $ 
Horizontal=�   $ 3Q�$ 0Q�$ #C24F48��.+��� $
��Bold"�$��14(�$��Center=����#FFFFFF使用�� $��30(�$
��Bold"�$��Center=�$	��4,0q����#ffd74e10�� $��14(�$
��Bold"�$��Center=����#FFFFFF个  $	��146��$��52��$��	126,0,0,0q�$
 
AllOpacity=�$@ :/LOLSkinGetter;component/Contents/Images/Body_Bd/spr_7.png��.���� $ 
Horizontal=�   $ 3Q�$ 0Q�$ #C24F48��.+��� $
��Bold"�$��14(�$��Center=����#FFFFFF使用�� $��30(�$
��Bold"�$��Center=�$	��4,0q����#ffd74e1�� $��14(�$
��Bold"�$��Center=����#FFFFFF个  -   $ btnUseTen10��$	��182��$��50��$��7,-2,0,0q�$
 
AllOpacity=�$A ;/LOLSkinGetter;component/Contents/Images/Body_Bd/spr_11.png��.���� $ 
Horizontal=�   $ 3Q�$ 0Q�$ #C24F48��.+��� $
��Bold"�$��14(�$��Center=����#FFFFFF使用�� $��30(�$
��Bold"�$��Center=�$	��4,0q����#ffd74e10�� $��14(�$
��Bold"�$��Center=����#FFFFFF个�� $ 
Horizontal=�$��Center=�$	��Top=�$	��960��$��
0,2528,0,0q�.+��� $��16(�$��88,0,0,0q�$
��Bold"�$
��Left=�$	��Top=����#FFFFFF$	��送���� $��16(�$
��18,0q�$
��Bold"�$
��Left=�$	��Top=����#ff5236$��"普通星光水晶"���� $��16(�$��0,0,0,0q�$
��Bold"�$
��Left=�$	��Top=����#FFFFFF$��可能会送你���� $��16(�$��	282,0,0,0q�$
��Bold"�$
��Left=�$	��Top=����#FFFFFF$	��送���� $��16(�$
��18,0q�$
��Bold"�$
��Left=�$	��Top=����#ff5236$��"璀璨星光水晶"���� $��16(�$��0,0,0,0q�$
��Bold"�$
��Left=�$	��Top=����#FFFFFF$��可能会送你���� $ 
Horizontal=�$��Center=�$	��Top=�$	��960��$��
0,2560,0,0q�.+�'   !LOLSkinGetter.SkinGetterXuanChuan  $��44,0,0,0q�   Source$D >/LOLSkinGetter;component/Contents/Images/Body_Bd/img_show1.jpg��   ViewBoxWidth$	 342Q�   	LeftWidth$	 340Q�   Number$ 5��  $��	180,0,0,0q�$	 338Q�$D >/LOLSkinGetter;component/Contents/Images/Body_Bd/img_show2.jpg��$	 336Q�$ 7���� $ 
Horizontal=�$��Center=�$	��Top=�$	��960��$��
0,3028,0,0q�.+��� $��Center=�$��	74,75,0,0q�.+��� $��14(�$��Center=�$	��Top=����#FFFFFF$`��Z物品栏中未领取的道具，可以领取至任意大区，或者参加道具合成。���� $��14(�$	��0,4q�$��Center=�$	��Top=����#FFFFFF$����使用道具合成功能，可以将任意3个英雄（期限、非期限）合成一个非期限英雄，或将任意3个皮肤（期限、非期限）合成一个非期限皮肤。���� $��14(�$��Center=�$	��Top=����#FFFFFF$W��Q合成获得的道具可以领取至任意大区，或继续用于道具合成。���� $ 
Horizontal=�$��Center=�$	��Top=�$	��960��$��
0,3224,0,0q�.+�  $	��228��$��	278,0,0,0q�$��52��$
 
AllOpacity=�$@ :/LOLSkinGetter;component/Contents/Images/Body_Bd/spr_8.png��.���� $��16(�$
��Bold"�$��Center=����#FFFFFF查询我的英雄和皮肤  $��19,0,0,0q�$
 
AllOpacity=�$A ;/LOLSkinGetter;component/Contents/Images/Body_Bd/spr_11.png��.���� $��16(�$
��Bold"�$��Center=����#FFFFFF我要合成奖励%   LOLSkinGetter.SkinGetterDisplay  $��
0,3342,0,0q�   Left1$ 神秘星光水晶��   Left2$ 奖励��   
AllSources �� *ShenMi+  $��
7,3636,0,0q�$ 普通星光水晶��$ 奖励�� �� *PuTong+  $��
7,3930,0,0q�$ 璀璨星光水晶��$ 奖励�� �� *CuiCan+� $��
0,190,28,0q�$	��164��$	��Top=�$��Right=�$	��417������  �� ImageSource$F @/LOLSkinGetter;component/Contents/Images/Body_Bd/bg-side-nav.png��.+��� $��Center=�$	��Top=�$��0,74,0,0q�.+�,  &Ay.Framework.WPF.Controls.AyTextButton  -     Name$ btnStep1��
  � Tag$  1�����#FFFFFF!   ForegroundMouseEnter$! #FFF383��"   ForegroundPressed$" #FFF383��$
 Hand��#   ForegroundDisabled$# #FFFFFF��$   Text$$ 充值钻石��$��16(�$	��164��$��0q�
������ $��41��% � FocusVisualStyle% Z�   -   $ btnStep2��$  2�����#FFFFFF$! #FFF383��$" #FFF383��$
 Hand��$# #FFFFFF��$$ 兑换守卫皮肤��$��16(�$	��164��$��0q�
������ $��41��% Z�   -	   $ btnStep3��$  3�����#FFFFFF$! #FFF383��$" #FFF383��$
 Hand��$# #FFFFFF��$$ 送星光水晶��$��16(�$	��164��$��0q�
������ $��41��% Z�   -
   $ btnStep4��$  4�����#FFFFFF$! #FFF383��$" #FFF383��$
 Hand��$# #FFFFFF��$$ 领取奖励��$��16(�$	��164��$��0q�
������ $��41��% Z�   -   $ btnStep5��$  5�����#FFFFFF$! #FFF383��$" #FFF383��$
 Hand��$# #FFFFFF��$$ 其他召唤师获得��$��16(�$	��164��$��0q�
������ $��41��% Z�   -   $ btnStep6��$  6�����#FFFFFF$! #FFF383��$" #FFF383��$
 Hand��$# #FFFFFF��$$ 活动规则��$��16(�$	��164��$��0q�
������ $��41��% Z�   -   $ btnStep7��$  7�����#FFFFFF$! #FFF383��$" #FFF383��$
 Hand��$# #FFFFFF��$$ 常见问题��$��16(�$	��164��$��0q�
������ $��41��% Z�   -   $ btnStep8��$  8�����#FFFFFF$! #FFF383��$" #FFF383��$
 Hand��$# #FFFFFF��$$ 联系客服��$��16(�$	��164��$��0q�
������ $��41��% Z� !   LOLSkinGetter.MessageDialog  -   &  Name$& md_zuanxiaofei��$��0,0,17,0q�$y�	Collapsed=�$��Stretch=�$��Stretch=����	#CC000000'   MWidth$	' 560Q�(   MHeight$	( 150Q�)   Title$) 温馨提示��*   Message$'* !赠送星光水晶中，请稍后��"	   LOLSkinGetter.SkinGetterChou	  -   + 	 Name$	+ sgc��$��Stretch=�$y�	Collapsed=�$��0,0,17,0q�$��Stretch=����	#CC000000