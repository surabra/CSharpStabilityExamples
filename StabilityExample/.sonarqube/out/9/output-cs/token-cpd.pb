ú
JC:\SVN\C16440\CSharpStabilityExamples\StatNullCheck\StatNullCheck\Form1.cs
	namespace 	
StatNullCheck
 
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
{ 	

MessageBox 
. 
Show 
( 
	SomeClass %
.% &
AnotherInstance& 5
.5 6
Name6 :
): ;
;; <
} 	
} 
} Ï
LC:\SVN\C16440\CSharpStabilityExamples\StatNullCheck\StatNullCheck\Program.cs
	namespace 	
StatNullCheck
 
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
} ‡
\C:\SVN\C16440\CSharpStabilityExamples\StatNullCheck\StatNullCheck\Properties\AssemblyInfo.cs
[ 
assembly 	
:	 

AssemblyTitle 
( 
$str (
)( )
]) *
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
$str *
)* +
]+ ,
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
]$$) *¾
NC:\SVN\C16440\CSharpStabilityExamples\StatNullCheck\StatNullCheck\SomeClass.cs
	namespace 	
StatNullCheck
 
{ 
public		 

class		 
AnotherClass		 
{

 
public 
string 
Name 
{ 
get  
;  !
set" %
;% &
}' (
} 
public 

static 
class 
	SomeClass !
{ 
public 
static 
AnotherClass "
AnotherInstance# 2
{3 4
get5 8
;8 9
set: =
;= >
}? @
} 
} 