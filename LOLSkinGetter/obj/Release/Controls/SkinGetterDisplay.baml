   M S B A M L   `   `   `  ���� H  DLOLSkinGetter, Version=2.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:LOLSkinGetterLOLSkinGetter  -clr-namespace:LOLSkinGetterLOLSkinGetter  %    LOLSkinGetter.SkinGetterDisplay   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SAy.Framework.WPF, Version=6.0.0.0, Culture=neutral, PublicKeyToken=bb01a39f4f86242fR NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     *ccclr-namespace:LOLSkinGetter     -localclr-namespace:LOLSkinGetter     .���� $
��1000��.+�� $��51��$��Stretch=�  � ColumnDefinitions  �� $��22 ��� $��10 ��� �� �� $��22 �.+���  �� Orientation$ 
Horizontal=�$��2��$
��Left=�$��Center=�.+��� $��24(�$��0q�$��Center=����#FFF$
��Bold"�����  �� Path$ Left1� �� RelativeSource ��  �� AncestorType" >� �� Mode$ FindAncestor=��� $��24(�$��0q����#FFF$��Center=����� $ Left2� �� " >�$ FindAncestor=��� -    ��Name$ sp_pagination��$ 
Horizontal=�$��Right=�$��Center=�$��3��$��0,0,10,0q�.+��� $��14(�$��0q����#FFF$��Center=�$	��第���� $	��5,0q�$��Georgia)�$��14(�$��Center=�$
��Bold"����#e16d66���� $ CurrentPageIndex� �� " >�$ FindAncestor=��� $��14(�$��0q����#FFF$��Center=�$��页/共���� $	��5,0q�$��Georgia)�$��14(�$��Center=�$
��Bold"����#FFF���� $ AllPageTotal� �� " >�$ FindAncestor=��� $��14(�$��0q�$��Center=����#FFF$	��页��� $	��220��$��	-10,0,0,0q�  �� $��22 ��� $��10 ��� $��* ��� $��22 �.+��� -    ��Name$ leftOpr�� � Cursor$
 Hand��$��22��$��44��$
��Left=�$��Center=�$y�	Collapsed=�$=��7/LOLSkinGetter;component/Contents/Images/Sow/spr_12.png���� -   $ rightOpr��$��0,0,0,0q�$��3��$y�	Collapsed=�$
 Hand��$��Right=�$��Center=�$=��7/LOLSkinGetter;component/Contents/Images/Sow/spr_14.png����    AyCItemPanel#���   $��2��$��	0,0,-10,0q�$��Hidden=�$��Hidden=����� $ DisplaySource� �� " >�$ FindAncestor=����� 	 �� DataType#   LOLSkinGetter.SkinGetterModel"	  .R�%   LOLSkinGetter.SkinGetterViewBox  $��0,0,14,0q�

 � Tag
 ��    CardType �� *
CardType+   
CardExpire �� *
CardExpire+   	CardPlace �� *	CardPlace+   	CardTitle �� *Title+   
CardStatus �� *
CardStatus+   HasXianDing �� *	IsLight+   CurrentImage �� *ID+  cic �� 	Converter# [ 