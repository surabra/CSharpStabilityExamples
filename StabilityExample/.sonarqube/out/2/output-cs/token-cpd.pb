Î

VC:\SVN\C16440\CSharpStabilityExamples\ComboBox_SelectItem\ComboBox_SelectItem\Form1.cs
	namespace 	
ComboBox_SelectItem
 
{ 
public 

partial 
class 
Form1 
:  
Form! %
{ 
public 
Form1 
( 
) 
{ 	
InitializeComponent 
(  
)  !
;! "
} 	
private 
void 
button1_Click "
(" #
object# )
sender* 0
,0 1
	EventArgs2 ;
e< =
)= >
{ 	
string 
selectedItem 
=  !
(" #
string# )
)) *
	comboBox1* 3
.3 4
SelectedItem4 @
;@ A
int 
length 
= 
selectedItem %
.% &
Length& ,
;, -
if 
( 
! 
string 
. 
IsNullOrEmpty $
($ %
selectedItem% 1
)1 2
)2 3
{ 
int 
len 
= 
selectedItem &
.& '
Length' -
;- .
}   
}"" 	
}## 
}$$ á
XC:\SVN\C16440\CSharpStabilityExamples\ComboBox_SelectItem\ComboBox_SelectItem\Program.cs
	namespace 	
ComboBox_SelectItem
 
{ 
static		 

class		 
Program		 
{

 
[ 	
	STAThread	 
] 
static 
void 
Main 
( 
) 
{ 	
Application 
. 
EnableVisualStyles *
(* +
)+ ,
;, -
Application 
. -
!SetCompatibleTextRenderingDefault 9
(9 :
false: ?
)? @
;@ A
Application 
. 
Run 
( 
new 
Form1  %
(% &
)& '
)' (
;( )
} 	
} 
} “
hC:\SVN\C16440\CSharpStabilityExamples\ComboBox_SelectItem\ComboBox_SelectItem\Properties\AssemblyInfo.cs
[ 
assembly 	
:	 

AssemblyTitle 
( 
$str .
). /
]/ 0
[		 
assembly		 	
:			 

AssemblyDescription		 
(		 
$str		 !
)		! "
]		" #
[

 
assembly

 	
:

	 
!
AssemblyConfiguration

  
(

  !
$str

! #
)

# $
]

$ %
[ 
assembly 	
:	 

AssemblyCompany 
( 
$str 
) 
] 
[ 
assembly 	
:	 

AssemblyProduct 
( 
$str 0
)0 1
]1 2
[ 
assembly 	
:	 

AssemblyCopyright 
( 
$str 0
)0 1
]1 2
[ 
assembly 	
:	 

AssemblyTrademark 
( 
$str 
)  
]  !
[ 
assembly 	
:	 

AssemblyCulture 
( 
$str 
) 
] 
[ 
assembly 	
:	 


ComVisible 
( 
false 
) 
] 
[ 
assembly 	
:	 

Guid 
( 
$str 6
)6 7
]7 8
[## 
assembly## 	
:##	 

AssemblyVersion## 
(## 
$str## $
)##$ %
]##% &
[$$ 
assembly$$ 	
:$$	 

AssemblyFileVersion$$ 
($$ 
$str$$ (
)$$( )
]$$) *