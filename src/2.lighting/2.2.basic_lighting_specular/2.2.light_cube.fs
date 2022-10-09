#version 330 core
in vec2 uvCoord;
out vec4 FragColor;

uniform sampler2D colorMap;

void main()
{
    FragColor = texture(colorMap, uvCoord);
}
