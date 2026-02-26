# Bateria songini

**Acordes**
```lilypond
\version "2.24.1"

\header {
    title="Bateria songini"
    composer="Jean Abraham Chacón Candanosa"
}
\score {
    <<
    \new Staff{
        \tempo 4 = 80
        \time 4/4
        \clef treble
        \set Staff.instrumentName = "Acordes"
        
        \repeat unfold 1{
            \chordmode{ c2 f2 d2:m c2 }
        }

        \repeat unfold 3{ 
            \chordmode{ c2 f2 e2:m d2:m d2:m c2 e2:m d2:m } 
        }
    }
    
    \new Staff{
        \clef treble
        \set Staff.instrumentName = "Medios"
        
        \transpose c c' {\repeat unfold 1{
            c'8 f'8 b8 c'16 r16 c'8 f'8 b8 c'16 r16 
            d'8 f'8 c'8 e'16 r16 d'8 f'8 c'8 e'16 r16
        }}
        
        \transpose c c' { \repeat unfold 1{
            \repeat unfold 2{ c'8 f'8 b8 c'16 r16 c'8 f'8 b8 c'16 r16 }
            \repeat unfold 2{ d'8 f'8 c'8 e'16 r16 d'8 f'8 c'8 e'16 r16 }
        }}
        
        \transpose c c'' {\repeat unfold 1{
            g8 r8 e8 r8 a8 r8 c'8 r8
            b8 r8 g8 r8 a8 r8 e8 r8
            g8 r8 b8 r8 e8 r8 c8 r8
            e8 r8 b8 r8 a8 r8 e8 r8
        }}
    }
    
    \new Staff{
        \clef treble
        \set Staff.instrumentName="Agudos"
        
        \repeat unfold 10{r1}
        
        \transpose c c'''{\repeat unfold 1{
            \repeat unfold 2{ r8 a8 r8 d8 }
            \repeat unfold 4{ r8 g8 r8 d8 }
            \repeat unfold 2{ r8 a8 r8 d8 }
        }}
    }
    
    \new DrumStaff{
        \set Staff.instrumentName = "Bateria"
        
        \repeat unfold 1{
            \drummode{<bd hh>8}
            \repeat unfold 11{ \drummode{hh8} } 
            \drummode{<bd hh>8}
            \repeat unfold 3 { \drummode{hh8} }
        }
        
        \repeat unfold 4{
            \drummode{<bd hh>16}
            \repeat unfold 3{ \drummode{hh16} }
            \drummode{<sn hh>16}
            \repeat unfold 2{ \drummode{hh16} }
            \drummode{<sn hh>16}
            \repeat unfold 2{ \drummode{hh16} }
            \drummode{<bd hh>16}
            \repeat unfold 1{ \drummode{hh16} }
            \drummode{<sn hh>16}
            \repeat unfold 3{ \drummode{hh16} }
        }
        
        \repeat unfold 4{
            \repeat unfold 16{ \drummode{hh16} }
        }
        
        \repeat unfold 4{
            \drummode{<bd hh>16}
            
            \repeat unfold 3{ \drummode{hh16} }
            
            \drummode{<sn hh>16}
            
            \drummode{hh16}
            
            \repeat unfold 2{ \drummode{<bd hh>16} }
            
            \repeat unfold 4{ \drummode{hh16} }
            
            \drummode{<sn hh>16}
            
            \repeat unfold 3{ \drummode{hh16} }
        }
    }

    >>
    \layout{}
    \midi{}
}
```

# Premisa
No se que hacer, estoy peridido. Ya no quiero pelear, estoy cansado. Solo Dios me salvara, hay batallas que no se ganan por voluntad, sino por gracia.


# Letra
No se que hacer.
Estoy perdido.
Ya no quiero pelear.
Estoy desesperado.

Repetir x3

---

Pero seguire.
Lo intentare.
No puedo solo.
Pero Dios me salvara.

Repetir x4
