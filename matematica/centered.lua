-- centered.lua
-- Convierte las lineas html centradas a algo que entienda pdf/odt.
-- Para html las deja tal cual.

local function extraer(texto)
  return texto:match('<p style="text%-align: center;">(.-)</p>')
end

function RawBlock(el)
  if el.format ~= 'html' then
    return nil
  end

  local contenido = extraer(el.text)
  if not contenido then
    return nil
  end

  if FORMAT:match('^html') then
    return nil
  elseif FORMAT:match('^latex') then
    return pandoc.RawBlock('latex', '\\begin{center}\n' .. contenido .. '\n\\end{center}')
  else
    return pandoc.Para(pandoc.Str(contenido))
  end
end